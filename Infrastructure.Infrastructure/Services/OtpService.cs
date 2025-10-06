using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System.Security.Cryptography;

namespace ReelsCommerceSystem.Application.Services;

public class OtpService : IOtpService
{
    private readonly UserManager<User> _userManager;
    private readonly IEmailService _emailService;
    private readonly IJwtService _jwtService;
    private const int OTP_LENGTH = 5;

    public OtpService(
        UserManager<User> userManager,
        IEmailService emailService,
        IJwtService jwtService)
    {
        _userManager = userManager;
        _emailService = emailService;
        _jwtService = jwtService;
    }

    public string GenerateOtp(string email)
    {
        // Generate a cryptographically secure 5-digit OTP (00000–99999)
        using var rng = RandomNumberGenerator.Create();
        var bytes = new byte[4];
        rng.GetBytes(bytes);
        var randomNumber = BitConverter.ToUInt32(bytes, 0);
        var otp = (randomNumber % 100000).ToString("D5"); // ensure exactly 5 digits
        return otp;
    }


    public async Task SendOtpAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            throw new InvalidOperationException("User not found");
        }

        // Generate new OTP
        var otpCode = GenerateOtp(email);

        // Update user's OTP
        user.Otp = new Otp
        {
            Code = otpCode,
            CreatedAt = DateTime.UtcNow
        };

        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            throw new InvalidOperationException("Failed to update user with OTP");
        }

        // Send OTP email
        var emailSent = _emailService.SendOTPEmail(email, otpCode);
        if (!emailSent)
        {
            throw new InvalidOperationException("Failed to send OTP email");
        }
    }

    public async Task<bool> ResendOtp(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            throw new InvalidOperationException("User not found");
        }

        // Check if user can resend OTP (using the CanResend property)
        if (user.Otp != null && !user.Otp.CanResend)
        {
            return false;
            //throw new InvalidOperationException("Please wait 1 minute before requesting a new OTP");
        }

        // Generate and send new OTP
        await SendOtpAsync(email);
        return true;
    }

    public async Task<bool> ValidateOtp(string email, string otp)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return false;
        }

        // Check if OTP exists
        if (user.Otp == null)
        {
            return false;
        }

        // Check if OTP is still valid (using the IsValid property)
        if (!user.Otp.IsValid)
        {
            return false;
        }

        // Validate OTP code
        if (user.Otp.Code != otp)
        {
            return false;
        }

        // OTP is valid - clear it and confirm email
        user.Otp = null;
        user.EmailConfirmed = true;

        await _userManager.UpdateAsync(user);

        // Generate JWT token for the user
        await _jwtService.CreateTokenAsync(user);

        return true;
    }
}