using ReelsCommerceSystem.Application.DTOs.Response.Dashboard;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IDashboardService
{
    Task<BrandDashboardRes> GetBrandDashboardAsync(string userId);
    Task<AdminDashboardRes> GetAdminDashboardAsync(int? year = null);
    Task<BrandReelAnalyticsRes> GetBrandReelAnalyticsAsync(string userId);
    Task<OrdersByRegionRes> GetOrdersByRegionAsync(string userId);
}
