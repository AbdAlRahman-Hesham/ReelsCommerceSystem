namespace ReelsCommerceSystem.Application.DTOs.Response.Brand;

public class BrandOwnerDetails
{
    public string UserId { get; set; } = null!;
    public string DisplayName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}
