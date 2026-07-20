namespace ReelsCommerceSystem.Application.DTOs.Request.Brand;

public class UpdateBrandDetailsReq
{
    public string DisplayName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ReturnPolicyAsHtml { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string Governorate { get; set; } = null!;
    public string District { get; set; } = null!;
    public int NumberOfEmployees { get; set; }
    public string? PayoutPhoneNumber { get; set; }
    public string? BankAccountNumber { get; set; }
    public string? BankCode { get; set; }
    public List<SocialLinkReqDto> SocialLinks { get; set; } = new();
}

public class SocialLinkReqDto
{
    public int? Id { get; set; }
    public string Platform { get; set; } = null!;
    public string Url { get; set; } = null!;
}
