using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;

public class ProductReviewLikeSpec : Specification<ProductReviewLike>
{
    public ProductReviewLikeSpec(string userId, ProductToggleLikeReq req) :
        base(criteria: like => like.ReviewId == req.ReviewId && like.UserId == userId)
    {
    }
}

public class ProductReviewDislikeSpec : Specification<ProductReviewDislike>
{
    public ProductReviewDislikeSpec(string userId, ProductToggleDislikeReq req) :
        base(criteria: dislike => dislike.ReviewId == req.ReviewId && dislike.UserId == userId)
    {
    }
}
