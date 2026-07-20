using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.Reviews;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations;

public class ProductReviewLikeConfig : IEntityTypeConfiguration<ProductReviewLike>
{
    public void Configure(EntityTypeBuilder<ProductReviewLike> builder)
    {
        builder.HasOne(like => like.Review)
            .WithMany(review => review.Likes)
            .HasForeignKey(like => like.ReviewId);
    }
}

public class ProductReviewDislikeConfig : IEntityTypeConfiguration<ProductReviewDislike>
{
    public void Configure(EntityTypeBuilder<ProductReviewDislike> builder)
    {
        builder.HasOne(dislike => dislike.Review)
            .WithMany(review => review.Dislikes)
            .HasForeignKey(dislike => dislike.ReviewId);
    }
}