namespace ReelsCommerceSystem.Application.DTOs.Request.Cart;

public class AddToCartReq
{
    public List<CartItemReq> Items { get; set; } = new();
}
