using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System.Security.Cryptography;

namespace ReelsCommerceSystem.Application.Services;

public class OtpService : IOtpService
{
    private readonly UserManager<User> _userManager;
    private readonly IEmailService _emailService;
    private readonly IJwtService _jwtService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly AppDbContext _dbContext;
    private const int OTP_LENGTH = 5;

    public OtpService(
        UserManager<User> userManager,
        IEmailService emailService,
        IJwtService jwtService,
        IUnitOfWork unitOfWork,
        AppDbContext dbContext)
    {
        _userManager = userManager;
        _emailService = emailService;
        _jwtService = jwtService;
        _unitOfWork = unitOfWork;
        _dbContext = dbContext;
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


    public async Task SendOtpAsync(string email, bool isForResetPassword = false, bool isForAccountDeletion = false)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
            throw new InvalidOperationException("User not found");

        // Generate new OTP
        var otpCode = GenerateOtp(email);

        // Update user's OTP directly via AppDbContext to fix change tracking for owned entity
        // We bypass UserManager.UpdateAsync which fails to track new Owned Types under NoTracking
        await _dbContext.Users
            .Where(u => u.Id == user.Id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.Otp.Code, otpCode)
                .SetProperty(u => u.Otp.CreatedAt, DateTime.UtcNow));

        // Send the appropriate email
        bool emailSent = false;
        if (isForAccountDeletion)
        {
            emailSent = _emailService.SendOTPEmailAccountDeletion(email, otpCode);
        }
        else if (isForResetPassword)
        {
            emailSent = _emailService.SendOTPEmailResetPassword(email, otpCode);
        }
        else
        {
            emailSent = _emailService.SendOTPEmail(email, otpCode);
        }

        if (!emailSent)
            throw new InvalidOperationException("Failed to send OTP email");
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

    public async Task<string?> ValidateOtp(string email, string otp)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return null;
        }

        // Check if OTP exists
        if (user.Otp == null)
        {
            return null;
        }

        // Check if OTP is still valid (using the IsValid property)
        if (!user.Otp.IsValid)
        {
            return null;
        }

        // Validate OTP code
        if (user.Otp.Code != otp)
        {
            return null;
        }

        // OTP is valid - clear it and confirm email
        // Use ExecuteUpdateAsync to explicitly update the database columns
        await _dbContext.Users
            .Where(u => u.Id == user.Id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.EmailConfirmed, true)
                .SetProperty(u => u.Otp.Code, (string)null)
                .SetProperty(u => u.Otp.CreatedAt, default(DateTime)));

        // Generate JWT token for the user
        var token = await _jwtService.CreateTokenAsync(user);

        return token;
    }
}