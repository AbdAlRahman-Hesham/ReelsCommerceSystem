using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class BrandReviewDislikes : BaseEntity
{
    public int ReviewId { get; set; }
    public string UserId { get; set; }
    public BrandReview Review { get; set; } = null!;

}
