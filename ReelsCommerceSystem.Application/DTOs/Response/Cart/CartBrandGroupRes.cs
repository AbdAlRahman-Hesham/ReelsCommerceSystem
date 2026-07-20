namespace ReelsCommerceSystem.Application.DTOs.Response.Cart;

public class CartBrandGroupRes
{
    public int BrandId { get; set; }
    public string BrandName { get; set; } = string.Empty;
    public string? BrandLogoUrl { get; set; }
    public List<CartItemRes> Items { get; set; } = new();
}
