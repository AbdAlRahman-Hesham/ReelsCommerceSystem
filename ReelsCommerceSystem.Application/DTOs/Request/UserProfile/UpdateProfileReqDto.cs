using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.UserProfile;

public class UpdateProfileReqDto
{
    [Required]
    public string FirstName { get; set; } = default!;
    [Required]
    public string LastName { get; set; } = default!;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = default!;
    [Required]
    [RegularExpression(@"^\+20(10|11|12|15)\d{8}$", ErrorMessage = "Invalid phone number format.")]
    public string PhoneNumber { get; set; } = default!;
}
