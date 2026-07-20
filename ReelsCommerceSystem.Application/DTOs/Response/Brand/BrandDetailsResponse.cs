namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class BrandDetailsResponse
{
    public int Id { get; set; }
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public string? CoverImageUrl { get; set; }
    public string ReturnPolicyAsHtml { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Governorate { get; set; } = null!;
    public string District { get; set; } = null!;
    public int NumberOfEmployees { get; set; }
    public string Status { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime? SubmittedAt { get; set; }
    public double AverageRating { get; set; }
    public int NumOfReviews { get; set; }
    public bool IsVerified { get; set; }
    public int FollowersCount { get; set; }
    public int ProductsCount { get; set; }
    public int ReelsCount { get; set; }
    public string? ContactPhone { get; set; }
    public string? PayoutPhoneNumber { get; set; }
    public string? BankAccountNumber { get; set; }
    public BrandOwnerDetails Owner { get; set; } = null!;
    public List<SocialLinkDto> SocialLinks { get; set; } = new();
}
