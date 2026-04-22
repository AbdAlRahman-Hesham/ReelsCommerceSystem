namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IOtpService
{
    public Task<string?> ValidateOtp(string email, string otp);
    public string GenerateOtp(string email);
    public Task<bool> ResendOtp(string email);
    public Task SendOtpAsync(string email, bool isForResetPassword = false, bool isForAccountDeletion = false);
}