namespace ReelsCommerceSystem.Shared.SpecificationsParams;

public record ProductSpecParams
{
    public string? Search { get; set; }
    public string? Color { get; set; }
    public string? Size { get; set; }
    public string? Status { get; set; }
    public decimal? MinPrice { get; set; }
    public decimal? MaxPrice { get; set; }
    public bool? HaveOffer { get; set; }

    public string? Sort { get; set; }

    public int? PageIndex { get; set; } = 1;
    public int? PageSize { get; set; } = 10;
}
