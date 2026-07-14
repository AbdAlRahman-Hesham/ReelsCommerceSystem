namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class GetAllBrandsResponse
{
    public int Id { get; set; }
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public string? CoverImageUrl { get; set; }
    public string Category { get; set; } = null!;
    public double AverageRating { get; set; }
    public int NumOfReviews { get; set; }
    public int ProductCount { get; set; }
    public int FollowersCount { get; set; }
    public bool IsFollowedByMe { get; set; }
}
