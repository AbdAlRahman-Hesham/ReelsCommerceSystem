using Microsoft.EntityFrameworkCore;

namespace ReelsCommerceSystem.Domain.Entities.UserEntities;
[Owned]
public class Otp
{
    public string Code { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // OTP valid for 10 minutes
    public bool IsValid => CreatedAt.AddMinutes(10) > DateTime.UtcNow;

    // User can resend OTP after 1 minute
    public bool CanResend => CreatedAt.AddMinutes(1) < DateTime.UtcNow;
}