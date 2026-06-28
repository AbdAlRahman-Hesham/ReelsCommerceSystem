namespace ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

public class TopReelDto
{
    public int ReelId { get; set; }
    public string Title { get; set; } = default!;
    public string? ThumbnailUrl { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }
}
