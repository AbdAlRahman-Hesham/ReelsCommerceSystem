using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class BrandPermissionService : IBrandPermissionService
    {
        private readonly AppDbContext _dbContext;

        public BrandPermissionService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CanAccessBrandFeaturesAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand != null && brand.Status != BrandStatus.BANNED;
        }

        public async Task<bool> CanManageProductsAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand != null && brand.Status == BrandStatus.APPROVED;
        }

        public async Task<bool> CanAccessAnalyticsAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand != null && brand.Status == BrandStatus.APPROVED;
        }

        public async Task<bool> CanManageReelsAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand != null && brand.Status == BrandStatus.APPROVED;
        }

        public async Task<bool> CanPublishContentAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand != null && brand.Status == BrandStatus.APPROVED;
        }

        public async Task<string?> GetBrandStatusAsync(string userId)
        {
            var brand = await GetBrandAsync(userId);
            return brand?.Status.ToString();
        }

        public async Task<bool> IsBannedAsync(string userId)
        {
            var user = await _dbContext.Users.AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == userId);
            return user?.IsBanned ?? false;
        }

        private async Task<Brand?> GetBrandAsync(string userId)
        {
            return await _dbContext.Brands
                .AsNoTracking()
                .FirstOrDefaultAsync(b => b.UserId == userId);
        }
    }
}
