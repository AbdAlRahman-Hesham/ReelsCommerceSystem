using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

//ERD
public class BrandReviewLike:BaseEntity
{
    public int ReviewId { get; set; }
    public string UserId { get; set; }
    public BrandReview Review { get; set; } = null!;

}
