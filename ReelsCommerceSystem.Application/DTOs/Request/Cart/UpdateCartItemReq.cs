using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.Cart;

public class UpdateCartItemReq
{
    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? Change { get; set; }
    
    [Required]
    public string Color { get; set; }

    [Required]
    public string Size { get; set; }
}
