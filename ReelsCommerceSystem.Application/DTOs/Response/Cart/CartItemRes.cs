namespace ReelsCommerceSystem.Application.DTOs.Response.Cart;

public class CartItemRes
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    //public string ProductMediaUrl { get; set; } = string.Empty;
    public List<string>? ProductMediaUrls { get; set; } = new();
    public decimal ProductPrice { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
