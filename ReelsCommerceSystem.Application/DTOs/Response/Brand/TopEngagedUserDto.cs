namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class TopEngagedUserDto
{
    public string UserId { get; set; } = null!;
    public string DisplayName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public double EngagementScore { get; set; }
    public int OrdersCount { get; set; }
    public int ReelViewsCount { get; set; }
    public int ReelLikesCount { get; set; }
    public int CommentsCount { get; set; }
    public int WishlistItemsCount { get; set; }
    public bool IsFollowing { get; set; }
}
