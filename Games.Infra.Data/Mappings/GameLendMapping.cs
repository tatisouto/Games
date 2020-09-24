using Games.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infra.Data.Mappings
{
    public class GameLendMapping : IEntityTypeConfiguration<GameLendModel>
    {
        public void Configure(EntityTypeBuilder<GameLendModel> builder)
        {

            builder.Property(c => c.Id)
            .HasColumnName("Id");

           
            builder.Property(e => e.IdPerson)
               .HasColumnType("uniqueidentifier")
               .IsRequired();

            builder.Property(e => e.IdGame)
              .HasColumnType("uniqueidentifier")
              .IsRequired();


            builder.Property(e => e.LendOn)
            .HasColumnType("datetime")
            .IsRequired();

            builder.Property(e => e.ReturnedOn)
           .HasColumnType("datetime")
           .IsRequired(false);

            builder.Property(e => e.Created)
           .HasColumnType("datetime")
           .IsRequired();

            builder.Property(e => e.Updated)
            .HasColumnType("datetime")
            .IsRequired(false);

        
        }
    }
}
