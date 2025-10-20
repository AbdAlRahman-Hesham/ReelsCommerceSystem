using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandService
    {
        Task<string?> GetBrandPolicyAsync(int brandId);
        Task<ToggleLikeRes> BrandReviewLikeAsync(string userId, ToggleLikeReq req);
    }
}
