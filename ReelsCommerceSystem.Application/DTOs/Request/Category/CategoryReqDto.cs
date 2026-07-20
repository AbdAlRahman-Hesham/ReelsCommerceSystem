using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Request.Category;

public class CategoryReqDto
{
    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string ArName { get; set; } = null!;

    [Required]
    public string ImageUrl { get; set; } = null!;

    public string? ImagePublicId { get; set; }
}
