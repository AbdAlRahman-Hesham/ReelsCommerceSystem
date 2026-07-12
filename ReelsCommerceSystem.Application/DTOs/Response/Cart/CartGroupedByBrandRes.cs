namespace ReelsCommerceSystem.Application.DTOs.Response.Cart;

public class CartGroupedByBrandRes
{
    public int CartId { get; set; }
    public string UserId { get; set; } = string.Empty;
    public List<CartBrandGroupRes> Brands { get; set; } = new();
}
