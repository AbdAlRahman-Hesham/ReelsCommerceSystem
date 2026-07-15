namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class ProductToggleLikeRes
{
    public int ReviewId { get; set; }
    public int TotalLikes { get; set; }
    public bool IsLiked { get; set; }
}
