namespace ReelsCommerceSystem.Application.DTOs.Request.Product;

public class ProductToggleDislikeReq
{
    public int ReviewId { get; set; }
    public bool IsDisliked { get; set; }
}
