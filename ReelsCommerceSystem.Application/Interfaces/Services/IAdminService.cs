using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Request.Admin;
using ReelsCommerceSystem.Application.DTOs.Response.Admin;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IAdminService
    {
        Task<ApiResponse<AdminLoginResDto>> LoginAsync(AdminLoginReqDto dto);

    }
}
