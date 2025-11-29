namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductSizeMapping
{
    public int Id { get; set; }

    public ProductColorMapping ProductColorMapping { get; set; }
    public int ProductColorMappingId { get; set; }

    public ProductSize ProductSize { get; set; }
    public int ProductSizeId { get; set; }

    public int Quantity { get; set; }
}
