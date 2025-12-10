using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReelAnalyticsService : IReelAnalyticsService
    {
        private readonly IGenericRepository<UserReelView> _userReelViewRepo;

        public ReelAnalyticsService(IGenericRepository<UserReelView> userReelViewRepo)
        {
            _userReelViewRepo = userReelViewRepo;
        }
        public async Task<List<TopBrandDto>> GetTopBrandsLastWeekAsync(int topN)
        {
            var lastWeek = DateTime.UtcNow.AddDays(-7);

           
            var recentViewsQuery = _userReelViewRepo.GetAllQueryable()
                .Where(v => v.CreatedAt >= lastWeek)
                .Include(v => v.Reel)
                .ThenInclude(r => r.Brand);

            var topBrands = await recentViewsQuery
                .GroupBy(v => new { v.Reel.BrandId, v.Reel.Brand.DisplayName })
                .Select(g => new TopBrandDto
                {
                    BrandId = g.Key.BrandId,
                    BrandName = g.Key.DisplayName,
                    TotalViews = g.Count()
                })
                .OrderByDescending(b => b.TotalViews)
                .Take(topN)
                .ToListAsync();

            return topBrands;

        }
    }
}
