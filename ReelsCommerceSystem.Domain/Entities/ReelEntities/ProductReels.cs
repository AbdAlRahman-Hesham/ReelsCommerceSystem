using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Domain.Entities.ReelEntities;

public class ProductReels:BaseEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    public int ReelId { get; set; }
    public Reel Reel { get; set; } = null!;
}