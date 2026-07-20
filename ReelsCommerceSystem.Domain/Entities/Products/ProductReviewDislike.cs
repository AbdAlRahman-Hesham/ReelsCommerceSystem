using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.Reviews;

public class ProductReviewDislike : BaseEntity
{
    public int ReviewId { get; set; }
    public string UserId { get; set; }
    public ProductReview Review { get; set; } = null!;
}
