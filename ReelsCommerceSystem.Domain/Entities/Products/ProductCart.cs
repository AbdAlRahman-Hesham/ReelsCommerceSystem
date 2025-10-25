using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;

namespace ReelsCommerceSystem.Domain.Entities.ProductCartEntities;

public class ProductCart : BaseEntity
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Decimal Price { get; set; }
    public string Category { get; set; }
    public string MediaUrl { get; set; } = null!;

    public int Quantity { get; set; }
    public int CartId { get; set; }
    public Cart? Cart { get; set; } = null!;

}
