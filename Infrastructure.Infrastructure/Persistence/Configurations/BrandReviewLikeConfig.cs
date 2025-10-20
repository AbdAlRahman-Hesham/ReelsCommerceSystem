using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Persistence.Configurations
{
    public class BrandReviewLikeConfig : IEntityTypeConfiguration<BrandReviewLike>
    {
        public void Configure(EntityTypeBuilder<BrandReviewLike> builder)
        {
            builder.HasOne(like=>like.Review).
                WithMany(review=>review.Likes).
                HasForeignKey(like=>like.ReviewId);
        }
    }
}
