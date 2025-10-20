namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class ToggleLikeRes
{
    public int ReviewId { get; set; }
    public int TotalLikes { get; set; }
    public bool IsLiked { get; set; }

}
public class ToggleDislikeRes
{
    public int ReviewId { get; set; }
    public int TotalDislikes { get; set; }
    public bool IsDisliked { get; set; }

}
