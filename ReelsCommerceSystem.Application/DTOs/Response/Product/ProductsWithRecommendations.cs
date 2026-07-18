using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.DTOs.Response.Product;

public class ProductsWithRecommendations
{
    public PaginationResponse<GetAllProductsResponse> Products { get; set; } = null!;
    public List<GetAllProductsResponse> RecommendedProducts { get; set; } = new();
}
