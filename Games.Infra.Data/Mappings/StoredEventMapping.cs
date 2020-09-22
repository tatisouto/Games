using Games.Domain.Core.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Infra.Data.Mappings
{
   
        public class StoredEventMapping : IEntityTypeConfiguration<StoredEvent>
        {
            public void Configure(EntityTypeBuilder<StoredEvent> builder)
            {
                builder.Property(c => c.Timestamp)
                    .HasColumnName("CreationDate");

                builder.Property(c => c.MessageType)
                    .HasColumnName("Action")
                    .HasColumnType("varchar(100)");
            }
        }
    
}
