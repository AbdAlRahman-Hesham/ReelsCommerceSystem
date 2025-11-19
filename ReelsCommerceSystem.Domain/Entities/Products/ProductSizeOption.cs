using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductSizeOption : BaseEntity
{
    public ProductSize Size { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();

}
