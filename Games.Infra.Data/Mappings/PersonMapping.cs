using Games.Domain.Models;
using Games.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infra.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<PersonModel>
    {
        public void Configure(EntityTypeBuilder<PersonModel> builder)
        {
            builder.Property(c => c.Id)
              .HasColumnName("Id");

            builder.Property(e => e.Name)
            .HasColumnType("varchar(150)")
            .IsRequired();

            builder.Property(e => e.Email)
          .HasColumnType("varchar(150)")
          .IsRequired();

            builder.Property(e => e.Phone)
            .HasColumnType("varchar(11)")
            .IsRequired();


            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.Updated)
            .HasColumnType("datetime")
            .IsRequired(false);

            //builder.ToTable("Persons");
        }
    }
}
