using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.UserProfile;

public class ShippingAddressReqDto
{
    [Required]
    public string Name { get; set; } = default!;
    [Required]
    public string Postcode { get; set; } = default!;
    [Required]
    public string Country { get; set; } = default!;
    [Required]
    public string Street { get; set; } = default!;
    [Required]
    public string City { get; set; } = default!;
    [Required]
    [RegularExpression(@"^\+20(10|11|12|15)\d{8}$", ErrorMessage = "Invalid phone number format.")]
    public string PhoneNumber { get; set; } = default!;
}
