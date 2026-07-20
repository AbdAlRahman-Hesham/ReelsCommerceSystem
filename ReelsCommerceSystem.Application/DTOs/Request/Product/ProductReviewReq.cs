using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product;

public class ProductReviewReq
{
    [Range(1, 5)]
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
}
