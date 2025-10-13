
namespace ReelsCommerceSystem.Application.DTOs.Response.OTP;

public class VerifyOtpRes
{
    public string Token { get; set; } = default!;
    public DateTime ExpiresAt { get; set; }
}