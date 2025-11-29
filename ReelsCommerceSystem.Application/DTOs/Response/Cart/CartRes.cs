namespace ReelsCommerceSystem.Application.DTOs.Response.Cart;

public class CartRes
{
    public int CartId { get; set; }
    public string UserId { get; set; } = string.Empty;
    public List<CartItemRes> CartItems { get; set; } = new();
}
