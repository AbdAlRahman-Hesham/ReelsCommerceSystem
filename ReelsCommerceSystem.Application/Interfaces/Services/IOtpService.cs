namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOtpService
{
    public bool ValidateOtp(string email, string otp);
    public string GenerateOtp(string email);
    public string ResendOtp(string email);
}