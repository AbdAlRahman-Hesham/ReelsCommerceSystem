namespace ReelsCommerceSystem.Application.DTOs.Response.Admin
{
    public class BrandRequestDetailsDto
    {
        public int Id { get; set; }
        public string Status { get; set; } = null!;
        public int CurrentStep { get; set; }
        public int? LastFailedStep { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public RejectionReasonDto? RejectionReason { get; set; }

        public UserInfoDto User { get; set; } = null!;
        public BrandInfoDto Brand { get; set; } = null!;
        public VerificationDto? Verification { get; set; }
    }

    public class UserInfoDto
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string ProfileImage { get; set; } = null!;
        public List<string> Interests { get; set; } = new();
    }

    public class BrandInfoDto
    {
        public string DisplayName { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Category { get; set; } = null!;
        public int NumberOfEmployees { get; set; }
        public string Country { get; set; } = null!;
        public string Governorate { get; set; } = null!;
        public string District { get; set; } = null!;
        public string ReturnPolicyAsHtml { get; set; } = null!;
    }

    public class VerificationDto
    {
        public string FullName { get; set; } = null!;
        public string NationalId { get; set; } = null!;
        public string? TaxNumber { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string IdFrontImage { get; set; } = null!;
        public string IdBackImage { get; set; } = null!;
        public string SelfieImage { get; set; } = null!;
    }

    public class RejectionReasonDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
