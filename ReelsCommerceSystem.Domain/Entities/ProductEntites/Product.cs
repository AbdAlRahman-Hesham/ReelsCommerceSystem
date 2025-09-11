using ReelsCommerceSystem.Domain.Common;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class Product:BaseEntity
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
}
