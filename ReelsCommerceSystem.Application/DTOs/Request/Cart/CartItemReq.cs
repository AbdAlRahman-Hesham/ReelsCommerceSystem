using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.Cart;

public class CartItemReq
{
    [Required]
    public int ProductId { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    [Required]
    public string Color { get; set; }
    
    [Required]
    [RegularExpression(@"^(xs|s|m|l|xl|xxl|XS|S|M|L|XL|XXL)$",
        ErrorMessage = "Size must be: xs|s|m|l|xl|xxl|XS|S|M|L|XL|XXL")]
    public string Size { get; set; }
}
