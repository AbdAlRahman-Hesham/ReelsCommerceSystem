namespace ReelsCommerceSystem.Application.DTOs.Request.Product;

public class ProductToggleLikeReq
{
    public int ReviewId { get; set; }
    public bool IsLiked { get; set; }
}
