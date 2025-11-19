using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;

namespace ReelsCommerceSystem.Domain.Entities.Reviews;

public class ProductReview:BaseEntity
{
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public string UserId { get; set; }
    public User User { get; set; } = null!;
}
