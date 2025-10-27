using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class Product:BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Category { get; set; } = null!;
    public decimal  Price { get; set; }
    public int Quantity { get; set; }
    public string MediaUrl { get; set; } = null!;
    public bool IsCustomizable { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    //ERD
    public decimal? DiscountPercentage { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;
    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    public ICollection<ProductCart> ProductCarts { get; set; } = new List<ProductCart>();
    public ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
    public ICollection<Reel> Reels { get; set; } = new List<Reel>();
    //ERD
    public virtual ICollection<WishlistItem>? WishlistItems { get; set; } = new HashSet<WishlistItem>();


}
