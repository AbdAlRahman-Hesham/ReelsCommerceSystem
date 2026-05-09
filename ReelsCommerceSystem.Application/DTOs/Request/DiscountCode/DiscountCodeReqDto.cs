using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.DiscountCode;

public class DiscountCodeReqDto
{
    [Required]
    public string Code { get; set; } = default!;
    
    [Required]
    public DateTime ExpirationDate { get; set; }
    
    [Required]
    [Range(0, 50, ErrorMessage = "Discount value must be between 0 and 50 percent")]
    public decimal DiscountValue { get; set; }
}
