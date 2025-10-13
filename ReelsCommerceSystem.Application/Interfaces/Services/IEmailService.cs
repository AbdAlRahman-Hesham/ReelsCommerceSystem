namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IEmailService
{ 
    public bool SendOTPEmail(string toEmail, string otp);
    public bool SendOTPEmailResetPassword(string toEmail, string otp);
}