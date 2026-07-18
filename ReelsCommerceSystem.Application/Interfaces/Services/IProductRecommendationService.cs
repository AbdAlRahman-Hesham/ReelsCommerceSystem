using ReelsCommerceSystem.Application.DTOs.Response.Product;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IProductRecommendationService
{
    Task<List<GetAllProductsResponse>> GetRecommendedProductsAsync(string? userId, int count = 10);
}
