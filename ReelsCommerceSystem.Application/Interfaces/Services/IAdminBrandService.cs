using ReelsCommerceSystem.Application.DTOs.Response.Admin;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IAdminBrandService
    {
        Task<PagedResponse<BrandRequestListDto>> GetBrandRequestsAsync(
            string? status = null,
            string? search = null,
            int page = 1,
            int pageSize = 20);
        Task<BrandRequestDetailsDto> GetDetailsAsync(int id);
        Task ApproveAsync(int id);
        Task RejectAsync(int id, int reasonId);
        Task BanUserAsync(int id);
        Task<int> GetPendingCountAsync();
    }
}
