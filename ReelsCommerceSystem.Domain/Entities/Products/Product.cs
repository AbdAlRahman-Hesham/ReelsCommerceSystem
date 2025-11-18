using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
    public string? ArDescription { get; set; }

    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string MediaUrl { get; set; } = null!;
    public bool IsCustomizable { get; set; }

    public decimal? DiscountPercentage { get; set; }
    public bool HaveOffer => DiscountPercentage != null ? ( DiscountPercentage > 0 ) : false;

    public int BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public int CategoryId { get; set; }
    public ProductCategory Category { get; set; }

    public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    public ICollection<ProductReview> Reviews { get; set; } = new List<ProductReview>();
    public ICollection<Reel> Reels { get; set; } = new List<Reel>();
    public virtual ICollection<WishlistItem>? WishlistItems { get; set; } = new HashSet<WishlistItem>();

    public ICollection<ProductColorMapping> AvailableColors { get; set; } = new List<ProductColorMapping>();
    public ICollection<ProductSizeMapping> AvailableSizes { get; set; } = new List<ProductSizeMapping>();
    public ICollection<ProductInformation> ProductInformations { get; set; } = new List<ProductInformation>();
    public StockStatus StockStatus { get; set; } = StockStatus.InStock;


}
