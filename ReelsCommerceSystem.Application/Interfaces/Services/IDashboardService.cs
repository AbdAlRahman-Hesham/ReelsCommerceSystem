using ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IDashboardService
{
    Task<BrandDashboardRes> GetBrandDashboardAsync(string userId);
    Task<AdminDashboardRes> GetAdminDashboardAsync();
    Task<BrandReelAnalyticsRes> GetBrandReelAnalyticsAsync(string userId);
}
