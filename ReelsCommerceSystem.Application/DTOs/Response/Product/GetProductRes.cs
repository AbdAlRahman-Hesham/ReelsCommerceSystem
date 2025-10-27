namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class GetProductRes
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public decimal? Discount { get; set; }
    public string BrandName { get; set; }
}
