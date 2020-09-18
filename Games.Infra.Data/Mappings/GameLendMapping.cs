using Games.Domain.Entities;
using Games.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Infra.Data.Mappings
{
    public class GameLendMapping : EntityTypeConfiguration<GameLend>
    {
        public override void Map(EntityTypeBuilder<GameLend> builder)
        {                      
           

            builder.HasKey(e => e.Id);

            builder.Property(e => e.LendOn)
            .HasColumnType("datetime")
            .IsRequired();

            builder.Property(e => e.ReturnedOn)
           .HasColumnType("datetime")
           .IsRequired();

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.Updated)
            .HasColumnType("datetime");

            builder.ToTable("GameLend");

           


         



        }
    }
}
