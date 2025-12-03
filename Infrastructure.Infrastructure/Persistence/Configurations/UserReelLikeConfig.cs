using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class UserReelLikeConfig : IEntityTypeConfiguration<UserReelLike>
{
    public void Configure(EntityTypeBuilder<UserReelLike> builder)
    {
        builder
            .HasIndex(u => new { u.UserId, u.ReelId })
            .IsUnique();
    }
}
