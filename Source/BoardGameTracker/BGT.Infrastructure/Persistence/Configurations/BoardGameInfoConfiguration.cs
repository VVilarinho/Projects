using BGT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BGT.Infrastructure.Persistence.Configurations
{
    public class BoardGameInfoConfiguration : IEntityTypeConfiguration<BoardGameInfo>
    {
        public void Configure(EntityTypeBuilder<BoardGameInfo> builder)
        {
            builder.Property(t => t.GameName)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}