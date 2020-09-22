using Games.Domain.Entities;
using Games.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infra.Data.Mappings
{
    public class PersonMapping : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(c => c.Id)
              .HasColumnName("Id");

            builder.Property(e => e.Name)
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
            .IsRequired();

            builder.ToTable("Persons");
        }
    }
}
