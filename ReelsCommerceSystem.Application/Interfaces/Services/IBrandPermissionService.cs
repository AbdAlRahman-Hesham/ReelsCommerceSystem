namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandPermissionService
    {
        Task<bool> CanAccessBrandFeaturesAsync(string userId);
        Task<bool> CanManageProductsAsync(string userId);
        Task<bool> CanAccessAnalyticsAsync(string userId);
        Task<bool> CanManageReelsAsync(string userId);
        Task<bool> CanPublishContentAsync(string userId);
        Task<string?> GetBrandStatusAsync(string userId);
        Task<bool> IsBannedAsync(string userId);
    }
}
