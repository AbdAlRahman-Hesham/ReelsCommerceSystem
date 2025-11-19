namespace ReelsCommerceSystem.Domain.Entities.ProductEntites;

public class ProductColor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ArName { get; set; }
    public string HexCode { get; set; }
    public ICollection<ProductColorMapping> ProductColorMapping { get; set; } = new List<ProductColorMapping>();
    public int Quantity { get; set; }

}
