using System.Text.Json.Serialization;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class GetProductResponse : GetAllProductsResponse
{
    [JsonPropertyOrder(102)]
    public List<ProductInformationDto> ProductInformations { get; set; } = new();

    [JsonPropertyOrder(103)]
    public List<ProductReviewDto>? Reviews { get; set; } = new();

    [JsonPropertyOrder(104)]
    public List<GetRelatedProductDto>? RelatedProducts { get; set; } = new();
}
