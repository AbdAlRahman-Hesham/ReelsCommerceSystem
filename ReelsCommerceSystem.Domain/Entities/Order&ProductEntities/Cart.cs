using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;

namespace ReelsCommerceSystem.Domain.Entities.CartEntities;

public class Cart:BaseEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string UserId { get; set; }
    public ICollection<ProductCart> ProductCarts { get; set; } = new List<ProductCart>();

}
