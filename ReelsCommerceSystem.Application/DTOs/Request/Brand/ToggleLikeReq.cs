

namespace ReelsCommerceSystem.Application.DTOs.Request.Brand;

public class ToggleLikeReq
{
    public int ReviewId { get; set; }
    public bool IsLiked { get; set; }
}
public class ToggleDislikeReq
{
    public int ReviewId { get; set; }
    public bool IsDisliked { get; set; }
}
