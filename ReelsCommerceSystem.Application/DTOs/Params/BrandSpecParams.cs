using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.DTOs.Params;

public record BrandSpecParams
{
    public string? Search { get; set; }
    public string? CategoryName { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "PageIndex must be at least 1")]
    public int? PageIndex { get; set; } = 1;

    [Range(1, 100, ErrorMessage = "PageSize must be between 1 and 100")]
    public int? PageSize { get; set; } = 10;
}
