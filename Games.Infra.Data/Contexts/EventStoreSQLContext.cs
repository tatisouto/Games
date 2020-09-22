using Games.Domain.Core.Events;
using Games.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;


namespace Games.Infra.Data.Contexts
{
    public class EventStoreSQLContext : DbContext
    {
        public EventStoreSQLContext(DbContextOptions<EventStoreSQLContext> options) : base(options) { }

        public DbSet<StoredEvent> StoredEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoredEventMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
