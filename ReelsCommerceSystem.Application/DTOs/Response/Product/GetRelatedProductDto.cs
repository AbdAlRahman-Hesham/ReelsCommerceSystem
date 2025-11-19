namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class GetRelatedProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? PictureUrl { get; set; }
    public decimal Price { get; set; }
    public decimal? DiscountedPrice
    {
        get
        {
            if (DiscountPercentage.HasValue && DiscountPercentage > 0)
            {
                return Price - (Price * DiscountPercentage.Value / 100);
            }
            return null;
        }
    }
    public decimal? DiscountPercentage { get; set; }
    public bool HaveOffer { get; set; }
}
