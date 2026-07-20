using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class ProductReviewByUserSpec : Specification<ProductReview>
{
    public ProductReviewByUserSpec(int productId, string userId)
        : base(r => r.ProductId == productId && r.UserId == userId)
    {
    }
}
