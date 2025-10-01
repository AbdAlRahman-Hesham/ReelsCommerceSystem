using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class OtpService: IOtpService
{
    public bool ValidateOtp(string email, string otp)
    {
        throw new NotImplementedException();
    }

    public string GenerateOtp(string email)
    {
        throw new NotImplementedException();
    }

    public string ResendOtp(string email)
    {
        throw new NotImplementedException();
    }
}