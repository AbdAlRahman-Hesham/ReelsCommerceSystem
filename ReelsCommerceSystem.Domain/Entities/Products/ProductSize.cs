using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductSize
{
    public int Id { get; set; }
    public Size Size { get; set; }
    public ICollection<ProductSizeMapping> Products { get; set; } = new List<ProductSizeMapping>();
}
