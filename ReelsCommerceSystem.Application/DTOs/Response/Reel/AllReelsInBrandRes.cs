namespace ReelsCommerceSystem.Application.DTOs.Response.Reel;

public class AllReelsInBrandRes
{
    public int ReelId { get; set; }
    public string Title { get; set; } = string.Empty; //////

    public string ThumbnailUrl { get; set; } = null!;
    public int NumOfWatches { get; set; }
    public int NumOfLikes { get; set; }
    public int NumOfShares { get; set; }
    public bool IsLiked { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string VideoUrl { get; set; } = null!;

}
