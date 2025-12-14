using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IReelAnalyticsService
    {
        Task<List<TopBrandDto>> GetTopBrandsLastWeekAsync(int topN);
    }
}
