using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ProductCartEntities;

public class CartProduct : BaseEntity
{
    public int ProductId { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;

    public string Category { get; set; }
    public string? Color { get; set; }
    public Size Size { get; set; }

    public bool IsCustomized { get; set; } = false;
    public string? MoreDetails { get; set; }
    //public string? MediaUrl { get; set; }
    public List<string>? MediaUrls { get; set; } = new();

    public decimal FinalPrice { get; set; }
}
