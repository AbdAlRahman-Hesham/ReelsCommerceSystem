namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandRegistrationStatusRes
    {
        public int CurrentStep { get; set; }
        public string Status { get; set; } = null!;
        public bool CanResume { get; set; }
        public int? LastFailedStep { get; set; }
        public string? RejectionReason { get; set; }
        public string? RejectionCode { get; set; }
        public DateTime? SubmittedAt { get; set; }
    }
}
