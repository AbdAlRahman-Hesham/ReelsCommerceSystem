namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductSizeMapping
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public ProductSize ProductSize { get; set; }
    public int ProductSizeId { get; set; }

    public int Quantity { get; set; }
}
