using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Enums;

namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductInformation : BaseEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public string Key { get; set; } = null!;
    public string Value { get; set; } = null!;
    public string? ArKey { get; set; }
    public string? ArValue { get; set; }
    public InformationType Type { get; set; }
    public string? Group { get; set; } // e.g., "General", "Technical", "Care", "Dimensions"
    public string? ArGroup { get; set; }
    public int DisplayOrder { get; set; } = 0;
}
