namespace ReelsCommerceSystem.Application.DTOs.Response.Admin
{
    public class BrandRequestListDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string OwnerName { get; set; } = null!;
        public string OwnerPhone { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Category { get; set; } = null!;
        public DateTime SubmittedAt { get; set; }
        public string Status { get; set; } = null!;
    }
}
