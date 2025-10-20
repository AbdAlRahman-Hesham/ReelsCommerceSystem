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
         Task<string?> GetBrandPolicyAsync(int brandId);
        Task<ApiResponse<BrandInfoRes>> GetBrandInfoAsync(int brandId);
        Task<ApiResponse<BrandFollowResponse>> ToggleFollowAsync(int brandId, string userId);
    }
}
