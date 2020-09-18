using Games.Domain.Entities;
using Games.Infra.Data.Extensions;
using Games.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Games.Infra.Data.Contexts
{
    public class GamesContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameLend> GameLends { get; set; }
        public DbSet<Person> Persons { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new PersonMapping());
            modelBuilder.AddConfiguration(new GameMapping());
            modelBuilder.AddConfiguration(new GameLendMapping());
           

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
