namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductColorMapping
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int ProductColorId { get; set; }
    public ProductColor ProductColor { get; set; }
    public int Quantity => AvailableSizes.Sum(s=>s.Quantity);
    public ICollection<ProductSizeMapping> AvailableSizes { get; set; } = new List<ProductSizeMapping>();


}