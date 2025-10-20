using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;


namespace ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;

public class BrandReviewLikeSpec :Specification<BrandReviewLike>
{
    public BrandReviewLikeSpec(string userId, ToggleLikeReq req) :
        base(
            criteria:(like => like.ReviewId == req.ReviewId && like.UserId == userId)
            )
    {
    }
    public BrandReviewLikeSpec(ToggleLikeReq req) :
        base(
            criteria: (like => like.ReviewId == req.ReviewId)
            )
    {
    }
}
public class BrandReviewDislikeSpec :Specification<BrandReviewDislikes>
{
    public BrandReviewDislikeSpec(string userId, ToggleDislikeReq req) :
        base(
            criteria:(like => like.ReviewId == req.ReviewId && like.UserId == userId)
            )
    {
    }
    public BrandReviewDislikeSpec(ToggleLikeReq req) :
        base(
            criteria: (like => like.ReviewId == req.ReviewId)
            )
    {
    }
}
