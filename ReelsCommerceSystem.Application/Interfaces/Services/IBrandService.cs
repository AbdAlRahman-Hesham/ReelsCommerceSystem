using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandService
    {
        Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId);
        Task<string?> GetBrandPolicyAsync(int brandId);
        Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req);
    }
}
