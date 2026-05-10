using ReelsCommerceSystem.Application.DTOs.Response.Lookup;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface ILookupService
{
    Task<ApiResponse<List<string>>> GetCountriesAsync();
    Task<ApiResponse<List<string>>> GetCitiesByCountryAsync(string country);
    Task<ApiResponse<List<ColorLookupResDto>>> GetColorsAsync();
    Task<ApiResponse<List<LookupResDto>>> GetSizesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetOrderStatusesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetStockStatusesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetPaymentStatusesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetPaymentMethodsAsync();
    Task<ApiResponse<List<LookupResDto>>> GetInformationTypesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetDisputeStatusesAsync();
    Task<ApiResponse<List<LookupResDto>>> GetReelStatusesAsync();
    Task<ApiResponse<List<DeliveryMethodLookupResDto>>> GetDeliveryMethodsAsync();
}
