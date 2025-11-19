using System.Text.Json.Serialization;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class GetProductResponse : GetAllProductsResponse
{
    [JsonPropertyOrder(100)]
    public List<ProductColorDto> AvailableColors { get; set; } = new();

    [JsonPropertyOrder(101)]
    public List<ProductSizeDto> AvailableSizes { get; set; } = new();

    [JsonPropertyOrder(102)]
    public List<ProductInformationDto> ProductInformations { get; set; } = new();

    [JsonPropertyOrder(103)]
    public List<ProductReviewDto>? Reviews { get; set; } = new();

    [JsonPropertyOrder(104)]
    public List<GetRelatedProductDto>? RelatedProducts { get; set; } = new();
}
