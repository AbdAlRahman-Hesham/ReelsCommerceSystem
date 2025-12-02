namespace ReelsCommerceSystem.Application.DTOs.Response.Reel;

public class AllReelsInBrandRes
{
    public int ReelId { get; set; }
    public string ThumbnailUrl { get; set; } = null!;
    public int NumOfWatches { get; set; }
    public int NumOfLikes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string VideoUrl { get; set; } = null!;

}
