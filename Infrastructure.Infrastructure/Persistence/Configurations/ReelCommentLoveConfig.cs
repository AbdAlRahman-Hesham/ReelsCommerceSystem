using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ReelCommentLoveConfig : IEntityTypeConfiguration<ReelCommentLove>
{
    public void Configure(EntityTypeBuilder<ReelCommentLove> builder)
    {
     builder.HasIndex(rcl => new { rcl.ReelCommentId, rcl.UserId })
            .IsUnique();
    }
}