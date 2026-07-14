using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IBrandService
{
    Task<ApiResponse<PaginationResponse<GetAllBrandsResponse>>> GetBrandsAsync(BrandSpecParams specParams, string? userId = null);
    Task<ApiResponse<List<string>>> GetBrandCategoriesAsync();
    Task<ApiResponse<CreateBrandRes>> CreateBrandAsync(string userId, CreateBrandReq dto);
    Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId, string? userId = null);
    Task<string?> GetBrandPolicyAsync(int brandId);
    Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req);
    Task<ToggleDislikeRes> BrandReviewDislikeAsync(string userId, ToggleDislikeReq req);
    Task<ApiResponse<BrandFollowResponse>> ToggleFollowAsync(int brandId, string userId);
    Task<ApiResponse<string>> AddOrUpdateReview(int brandId, string userId, BrandReviewReq dto);
    Task<ApiResponse<double>> GetAverageRating(int brandId);
    Task<ApiResponse<GetMyBrandRes>> GetMyBrandAsync(string userId);
    Task<ApiResponse<BrandOwnerRes>> GetBrandOwnerAsync(int brandId);
    Task<ApiResponse<BrandRegistrationStatusRes>> GetBrandStatusAsync(string userId);
    Task<ApiResponse<List<BrandFollowResponse>>> GetFollowedBrandsAsync(string userId);
}
