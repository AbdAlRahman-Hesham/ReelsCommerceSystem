using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IProductService
{
    Task<ApiResponse<PaginationResponse<GetAllProductsResponse>>> GetProductsAsync(ProductSpecParams productSpecParams);
    Task<ApiResponse<PaginationResponse<GetAllProductsForAiResponse>>> GetAllProductsForAiAsync();
    Task<ApiResponse<GetProductResponse>> GetProductAsync(int productId);
    Task<ApiResponse<List<ProductCategoryResponse>>> GetProductCategoriesAsync();
    Task<ApiResponse<string>> AddOrUpdateProductReview(int productId, string userId, ProductReviewReq dto);
    Task<ProductToggleLikeRes> ProductReviewLikeAsync(string userId, ProductToggleLikeReq req);
    Task<ProductToggleDislikeRes> ProductReviewDislikeAsync(string userId, ProductToggleDislikeReq req);
    Task<ApiResponse<double>> GetProductAverageRating(int productId);
    Task<ApiResponse<ProductsWithRecommendations>> GetProductsWithRecommendationsAsync(ProductSpecParams productSpecParams);
}
