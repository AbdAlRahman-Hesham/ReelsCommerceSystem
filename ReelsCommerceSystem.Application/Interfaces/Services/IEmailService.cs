namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IEmailService
{ 
    public bool SendOTPEmail(string toEmail, string otp);
}