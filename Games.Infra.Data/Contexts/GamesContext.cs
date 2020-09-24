using FluentValidation.Results;
using Games.Domain.Models;
using Games.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetDevPack.Data;
using NetDevPack.Domain;
using NetDevPack.Mediator;
using NetDevPack.Messaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Infra.Data.Contexts
{
    public class GamesContext : DbContext, IUnitOfWork
    {
        private readonly IMediatorHandler _mediatorHandler;

        public GamesContext(DbContextOptions<GamesContext> options, IMediatorHandler mediatorHandler) : base(options)
        {
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<GameModel> Games { get; set; }
        public DbSet<GameLendModel> GameLends { get; set; }
        public DbSet<PersonModel> Persons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Ignore<ValidationResult>();
            modelBuilder.Ignore<Event>();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
              e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfiguration(new GameMapping());
            modelBuilder.ApplyConfiguration(new PersonMapping());
            modelBuilder.ApplyConfiguration(new GameLendMapping());

            modelBuilder.Entity<GameLendModel>()
            .HasOne(bc => bc.Games)
            .WithMany(b => b.GameLend)
            .HasForeignKey(bc => bc.IdGame);

            modelBuilder.Entity<GameLendModel>()
            .HasOne(bc => bc.Persons)
            .WithMany(b => b.GameLend)
            .HasForeignKey(bc => bc.IdPerson);


            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {

            await _mediatorHandler.PublishDomainEvents(this).ConfigureAwait(false);

            var success = await SaveChangesAsync() > 0;

            return success;
        }


    }

    public static class MediatorExtension
    {
        public static async Task PublishDomainEvents<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvents());

            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublishEvent(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
