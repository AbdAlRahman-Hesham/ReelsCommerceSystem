using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities;

public class BrandReview:BaseEntity
{
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string UserId { get; set; }
    public User User { get; set; } = null!;
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public int NumOfLikes { get; set; }
    public int NumOfDislikes { get; set; }
    public virtual ICollection<BrandReviewLike>? Likes { get; set; } = new HashSet<BrandReviewLike>();
    public virtual ICollection<BrandReviewDislikes>? Dislikes { get; set; } = new HashSet<BrandReviewDislikes>();

}