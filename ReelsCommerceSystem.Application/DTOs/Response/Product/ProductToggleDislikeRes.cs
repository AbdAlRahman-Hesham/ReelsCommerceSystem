namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class ProductToggleDislikeRes
{
    public int ReviewId { get; set; }
    public int TotalDislikes { get; set; }
    public bool IsDisliked { get; set; }
}
