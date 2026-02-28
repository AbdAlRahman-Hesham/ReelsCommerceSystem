using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IBrandService
{
    Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId);
    Task<string?> GetBrandPolicyAsync(int brandId);
    Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req);
    Task<ToggleDislikeRes> BrandReviewDislikeAsync(string userId, ToggleDislikeReq req);
    Task<ApiResponse<BrandFollowResponse>> ToggleFollowAsync(int brandId, string userId);
    Task<ApiResponse<string>> AddOrUpdateReview(int brandId, string userId, BrandReviewReq dto);
    Task<ApiResponse<double>> GetAverageRating(int brandId);
}
