namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class BrandReviewRes
{
    public int ReviewId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public int NumOfLikes { get; set; }
    public int NumOfDislikes { get; set; }

    public string UserDisplayName { get; set; } = null!;
    public string UserImageUrl { get; set; } = null!;
    public bool IsLike { get; set; }
    public bool IsDislike { get; set; }

}