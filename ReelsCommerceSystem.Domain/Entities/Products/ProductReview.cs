using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReelsCommerceSystem.Domain.Entities.Reviews;

public class ProductReview : BaseEntity
{
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public string UserId { get; set; }
    public User User { get; set; } = null!;
    [NotMapped]
    public int NumOfLikes { get; set; }
    [NotMapped]
    public int NumOfDislikes { get; set; }
    public virtual ICollection<ProductReviewLike>? Likes { get; set; } = new HashSet<ProductReviewLike>();
    public virtual ICollection<ProductReviewDislike>? Dislikes { get; set; } = new HashSet<ProductReviewDislike>();
}
