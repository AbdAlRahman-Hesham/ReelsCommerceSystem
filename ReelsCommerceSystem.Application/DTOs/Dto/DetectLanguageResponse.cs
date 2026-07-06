namespace ReelsCommerceSystem.Application.DTOs.Dto
{
    public class DetectLanguageResponse
    {
        public bool Success { get; set; }
        public string? Language { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
