using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IAdminBrandService
    {
        Task<List<BrandDetailsDto>> GetPendingAsync();
        Task<BrandDetailsDto>GetDetailsAsync(int id);

        Task ApproveAsync(int id);
        Task RejectAsync(int id, int reasonId);
        Task BanUserAsync(int id);
    }
}
