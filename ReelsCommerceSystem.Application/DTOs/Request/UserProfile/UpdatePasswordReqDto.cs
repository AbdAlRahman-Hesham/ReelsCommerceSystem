using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.UserProfile;

public class UpdatePasswordReqDto
{
    [Required]
    public string CurrentPassword { get; set; } = default!;
    [Required]
    [MinLength(6)]
    public string NewPassword { get; set; } = default!;
}
