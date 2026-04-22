namespace ReelsCommerceSystem.Application.DTOs.Params;

using System.ComponentModel.DataAnnotations;

public record ProductSpecParams
{
    public string? Search { get; set; }
    public string? Category { get; set; }

    public List<string>? Colors { get; set; }
    public List<string>? Sizes { get; set; }
    public int? BrandId { get; set; }

    [RegularExpression(@"^(InStock|OutStock|Out Stock|IN Stock)$",
        ErrorMessage = "StockStatus must be: InStock, OutStock, Out Stock, or IN Stock")]
    public string? StockStatus { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "MinPrice must be a positive number")]
    public decimal? MinPrice { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "MaxPrice must be a positive number")]
    public decimal? MaxPrice { get; set; }

    public bool? HaveOffer { get; set; }

    [RegularExpression(@"^(name|price|createdat|date|discount|popularity|rating)$",
        ErrorMessage = "SortBy must be: name, price, createdat, date, discount, popularity, or rating")]
    public string? SortBy { get; set; }

    [RegularExpression(@"^(desc|asc)$",
        ErrorMessage = "SortOrder must be: desc or asc")]
    public string? SortOrder { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "PageIndex must be at least 1")]
    public int? PageIndex { get; set; } = 1;

    [Range(1, 100, ErrorMessage = "PageSize must be between 1 and 100")]
    public int? PageSize { get; set; } = 10;
}