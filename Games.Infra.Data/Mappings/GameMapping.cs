using Games.Domain.Entities;
using Games.Infra.Data.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infra.Data.Mappings
{
    public class GameMapping : EntityTypeConfiguration<Game>
    {
        public override void Map(EntityTypeBuilder<Game> builder)
        {

            builder.Property(e => e.Description)
            .HasColumnType("varchar(150)")
            .IsRequired();

            builder.Property(e => e.Active)
            .HasColumnType("bit")
            .IsRequired();


            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.Updated)
            .HasColumnType("datetime")
            .IsRequired();          

            builder.ToTable("Games");
        }
    }
}
