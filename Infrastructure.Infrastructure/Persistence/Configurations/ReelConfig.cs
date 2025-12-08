using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ReelConfig : IEntityTypeConfiguration<Reel>
{
    public void Configure(EntityTypeBuilder<Reel> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.VideoUrl)
               .IsRequired();

        // Brand relationship - NO ACTION (to avoid cascade conflicts)
        builder.HasOne(r => r.Brand)
               .WithMany(b => b.Reels)
               .HasForeignKey(r => r.BrandId)
               .OnDelete(DeleteBehavior.NoAction);

    }
}
