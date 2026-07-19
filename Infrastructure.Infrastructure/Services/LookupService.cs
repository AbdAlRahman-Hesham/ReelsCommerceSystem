using System.Net;
using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Response.Lookup;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Domain.Enums.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class LookupService(HttpClient _httpClient, IMemoryCache _cache, AppDbContext _context) : ILookupService
{
    private const string CountriesApiUrl = "https://countriesnow.space/api/v0.1/countries";
    private const string CitiesApiUrl = "https://countriesnow.space/api/v0.1/countries/cities";
    private static readonly TimeSpan CacheDuration = TimeSpan.FromHours(24);

    public async Task<ApiResponse<List<string>>> GetCountriesAsync()
    {
        const string cacheKey = "all_countries";

        if (_cache.TryGetValue(cacheKey, out List<string>? countries))
        {
            return ApiResponse<List<string>>.SuccessResponse(countries!, HttpStatusCode.OK, "Countries fetched from cache", "تم جلب الدول من الكاش");
        }

        try
        {
            var response = await _httpClient.GetFromJsonAsync<CountriesNowResponse<CountryInfo>>(CountriesApiUrl);

            if (response == null || response.Error)
            {
                return ApiResponse<List<string>>.ErrorResponse(HttpStatusCode.InternalServerError, response?.Msg ?? "Failed to fetch countries", "فشل في جلب الدول");
            }

            countries = response.Data.Select(c => c.Country).OrderBy(c => c).ToList();
            _cache.Set(cacheKey, countries, CacheDuration);

            return ApiResponse<List<string>>.SuccessResponse(countries, HttpStatusCode.OK, "Countries fetched successfully", "تم جلب الدول بنجاح");
        }
        catch (Exception)
        {
            return ApiResponse<List<string>>.ErrorResponse(HttpStatusCode.InternalServerError, "An error occurred while fetching countries", "حدث خطأ أثناء جلب الدول");
        }
    }

    public async Task<ApiResponse<List<string>>> GetCitiesByCountryAsync(string country)
    {
        string cacheKey = $"cities_{country.ToLower()}";

        if (_cache.TryGetValue(cacheKey, out List<string>? cities))
        {
            return ApiResponse<List<string>>.SuccessResponse(cities!, HttpStatusCode.OK, "Cities fetched from cache", "تم جلب المدن من الكاش");
        }

        try
        {
            var requestBody = new { country = country };
            var response = await _httpClient.PostAsJsonAsync(CitiesApiUrl, requestBody);
            
            if (!response.IsSuccessStatusCode)
            {
                 return ApiResponse<List<string>>.ErrorResponse(HttpStatusCode.InternalServerError, "Failed to fetch cities for the specified country", "فشل في جلب المدن للدولة المحددة");
            }

            var result = await response.Content.ReadFromJsonAsync<CountriesNowResponse<string>>();

            if (result == null || result.Error)
            {
                return ApiResponse<List<string>>.ErrorResponse(HttpStatusCode.InternalServerError, result?.Msg ?? "Failed to fetch cities", "فشل في جلب المدن");
            }

            cities = result.Data.OrderBy(c => c).ToList();
            _cache.Set(cacheKey, cities, CacheDuration);

            return ApiResponse<List<string>>.SuccessResponse(cities, HttpStatusCode.OK, "Cities fetched successfully", "تم جلب المدن بنجاح");
        }
        catch (Exception)
        {
            return ApiResponse<List<string>>.ErrorResponse(HttpStatusCode.InternalServerError, "An error occurred while fetching cities", "حدث خطأ أثناء جلب المدن");
        }
    }

    public async Task<ApiResponse<List<ColorLookupResDto>>> GetColorsAsync()
    {
        const string cacheKey = "lookup_colors_v4";
        if (_cache.TryGetValue(cacheKey, out List<ColorLookupResDto>? colors))
        {
            return ApiResponse<List<ColorLookupResDto>>.SuccessResponse(colors!, HttpStatusCode.OK, "Colors fetched from cache", "تم جلب الألوان من الكاش");
        }

        colors = await _context.Set<ProductColor>().Select(c => new ColorLookupResDto
        {
            Id = c.Id,
            Name = c.Name,
            ArName = c.ArName,
            HexCode = c.HexCode
        }).ToListAsync();

        _cache.Set(cacheKey, colors, CacheDuration);
        return ApiResponse<List<ColorLookupResDto>>.SuccessResponse(colors, HttpStatusCode.OK, "Colors fetched successfully", "تم جلب الألوان بنجاح");
    }

    public async Task<ApiResponse<List<LookupResDto>>> GetSizesAsync()
    {
        const string cacheKey = "lookup_sizes_v2";
        if (_cache.TryGetValue(cacheKey, out List<LookupResDto>? sizes))
        {
            return ApiResponse<List<LookupResDto>>.SuccessResponse(sizes!, HttpStatusCode.OK, "Sizes fetched from cache", "تم جلب الأحجام من الكاش");
        }

        sizes = await _context.Set<ProductSize>().Select(s => new LookupResDto
        {
            Id = s.Id,
            Name = s.Size.ToString()
        }).ToListAsync();

        _cache.Set(cacheKey, sizes, CacheDuration);
        return ApiResponse<List<LookupResDto>>.SuccessResponse(sizes, HttpStatusCode.OK, "Sizes fetched successfully", "تم جلب الأحجام بنجاح");
    }

    public Task<ApiResponse<List<LookupResDto>>> GetOrderStatusesAsync() => 
        GetCachedEnumLookup<OrderStatus>("lookup_order_statuses", "Order statuses fetched successfully", "تم جلب حالات الطلب بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetStockStatusesAsync() => 
        GetCachedEnumLookup<StockStatus>("lookup_stock_statuses", "Stock statuses fetched successfully", "تم جلب حالات المخزون بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetPaymentStatusesAsync() => 
        GetCachedEnumLookup<PaymentStatus>("lookup_payment_statuses", "Payment statuses fetched successfully", "تم جلب حالات الدفع بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetPaymentMethodsAsync() => 
        GetCachedEnumLookup<PaymentMethod>("lookup_payment_methods", "Payment methods fetched successfully", "تم جلب طرق الدفع بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetInformationTypesAsync() => 
        GetCachedEnumLookup<InformationType>("lookup_information_types", "Information types fetched successfully", "تم جلب أنواع المعلومات بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetDisputeStatusesAsync() => 
        GetCachedEnumLookup<DisputeStatus>("lookup_dispute_statuses", "Dispute statuses fetched successfully", "تم جلب حالات النزاع بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetReelStatusesAsync() => 
        GetCachedEnumLookup<ReelStatus>("lookup_reel_statuses", "Reel statuses fetched successfully", "تم جلب حالات الفيديو بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetSettlementStatusesAsync() =>
        GetCachedEnumLookup<SettlementStatus>("lookup_settlement_statuses", "Settlement statuses fetched successfully", "تم جلب حالات التسوية بنجاح");

    public Task<ApiResponse<List<LookupResDto>>> GetWithdrawalRequestStatusesAsync() =>
        GetCachedEnumLookup<WithdrawalRequestStatus>("lookup_withdrawal_request_statuses", "Withdrawal request statuses fetched successfully", "تم جلب حالات طلبات السحب بنجاح");

    public async Task<ApiResponse<List<DeliveryMethodLookupResDto>>> GetDeliveryMethodsAsync()
    {
        const string cacheKey = "lookup_delivery_methods";
        if (_cache.TryGetValue(cacheKey, out List<DeliveryMethodLookupResDto>? deliveryMethods))
        {
            return ApiResponse<List<DeliveryMethodLookupResDto>>.SuccessResponse(deliveryMethods!, HttpStatusCode.OK, "Delivery methods fetched successfully (cached)", "تم جلب طرق التوصيل بنجاح (من الكاش)");
        }

        deliveryMethods = new List<DeliveryMethodLookupResDto>
        {
            new DeliveryMethodLookupResDto
            {
                Id = (int)DeliveryMethod.Standard,
                Name = DeliveryMethod.Standard.ToString(),
                ArName = "توصيل عادي",
                Price = 60
            },
            new DeliveryMethodLookupResDto
            {
                Id = (int)DeliveryMethod.Express,
                Name = DeliveryMethod.Express.ToString(),
                ArName = "توصيل سريع",
                Price = 120
            },
            new DeliveryMethodLookupResDto
            {
                Id = (int)DeliveryMethod.HomeDelivery,
                Name = DeliveryMethod.HomeDelivery.ToString(),
                ArName = "توصيل منزلي",
                Price = 80
            }
        };

        _cache.Set(cacheKey, deliveryMethods, CacheDuration);
        return ApiResponse<List<DeliveryMethodLookupResDto>>.SuccessResponse(deliveryMethods, HttpStatusCode.OK, "Delivery methods fetched successfully", "تم جلب طرق التوصيل بنجاح");
    }

    private async Task<ApiResponse<List<LookupResDto>>> GetCachedEnumLookup<TEnum>(string cacheKey, string enMessage, string arMessage) where TEnum : struct, Enum
    {
        if (_cache.TryGetValue(cacheKey, out List<LookupResDto>? values))
        {
            return ApiResponse<List<LookupResDto>>.SuccessResponse(values!, HttpStatusCode.OK, enMessage + " (cached)", arMessage + " (من الكاش)");
        }

        values = Enum.GetValues<TEnum>()
            .Select(e => new LookupResDto
            {
                Id = Convert.ToInt32(e),
                Name = e.ToString()
            }).ToList();

        _cache.Set(cacheKey, values, CacheDuration);
        return ApiResponse<List<LookupResDto>>.SuccessResponse(values, HttpStatusCode.OK, enMessage, arMessage);
    }

    private class CountriesNowResponse<T>
    {
        public bool Error { get; set; }
        public string Msg { get; set; }
        public List<T> Data { get; set; }
    }

    private class CountryInfo
    {
        public string Country { get; set; }
    }
}
