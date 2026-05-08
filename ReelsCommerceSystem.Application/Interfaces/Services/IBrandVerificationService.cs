using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandVerificationService
    {
        Task<ApiResponse<string>> VerifyBrandAsync(string userId, VerifyBrandReq request);
    }
}
