namespace ReelsCommerceSystem.Application.DTOs.Request.Cart;

public class UpdateCartReq
{
    public List<UpdateCartItemReq> Items { get; set; } = new();
}
