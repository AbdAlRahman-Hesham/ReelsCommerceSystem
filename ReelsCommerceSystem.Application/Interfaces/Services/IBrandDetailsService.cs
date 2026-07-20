using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IBrandDetailsService
{
    Task<ApiResponse<BrandDetailsResponse>> GetBrandDetailsAsync(int brandId, string? currentUserId = null);
    Task<ApiResponse<BrandDetailsResponse>> UpdateBrandDetailsAsync(int brandId, string userId, UpdateBrandDetailsReq dto);
    Task<ApiResponse<List<TopEngagedUserDto>>> GetTopEngagedUsersAsync(int brandId, int count = 10);
    Task<ApiResponse<string>> UploadLogoAsync(int brandId, string userId, IFormFile file);
    Task<ApiResponse<string>> UploadCoverAsync(int brandId, string userId, IFormFile file);
    Task<ApiResponse<bool>> DeleteLogoAsync(int brandId, string userId);
    Task<ApiResponse<bool>> DeleteCoverAsync(int brandId, string userId);
}
