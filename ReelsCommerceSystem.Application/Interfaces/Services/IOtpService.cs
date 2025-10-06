namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOtpService
{
    public Task<bool> ValidateOtp(string email, string otp);
    public string GenerateOtp(string email);
    public Task<bool> ResendOtp(string email);
    public Task SendOtpAsync(string email);
}