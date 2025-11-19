using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class RelatedProductService : IRelatedProductService
{
    private readonly IGenericRepository<Product> _genericRepository;
    private readonly IMemoryCache _memoryCache;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public RelatedProductService(IGenericRepository<Product> genericRepository,IMemoryCache memoryCache, IHttpContextAccessor httpContextAccessor)
    {
        _genericRepository = genericRepository;
        _memoryCache = memoryCache;
        _httpContextAccessor = httpContextAccessor;
    }
 
    public async Task<ApiResponse<List<GetRelatedProductDto>>> GetRelatedProductsAsync(int currentProductId, int take = 3)
    {
        string cacheKey = $"relatedProducts:{currentProductId}";

        if (_memoryCache.TryGetValue(cacheKey, out List<GetRelatedProductDto> cachedProducts))
        {
            return ApiResponse<List<GetRelatedProductDto>>.SuccessResponse(
                cachedProducts,
                HttpStatusCode.OK,
                en: "Fetched from cache successfully.",
                ar: "تم جلب المنتجات من الذاكرة المؤقتة بنجاح."
            );
        }

        var getProductByIdWithCategorySpec = new Specification<Product>(p => p.Id == currentProductId)
        {
            Includes = { p => p.Category }
        };

        var product = await _genericRepository.GetWithSpecAsync(getProductByIdWithCategorySpec);
        if (product == null)
        {
            return ApiResponse<List<GetRelatedProductDto>>.ErrorResponse(HttpStatusCode.NotFound,
                en: "Product not found.",
                ar: "المنتج غير موجود.");
        }

        var getRelatedProductsSpec = new Specification<Product>(criteria: p => p.Category != null &&
               p.Category.Name.ToLower() == product.Category.Name.ToLower() &&
               p.Id != currentProductId,pageIndex:1, pageSize:take)
        {
            
            Includes = { p => p.Category }
        };
        
        
        var relatedProducts = await _genericRepository.GetAllWithSpecAsync(getRelatedProductsSpec);

        var request = _httpContextAccessor.HttpContext?.Request;
        var host = $"{request?.Scheme}://{request?.Host.Value}";

        var relatedDtos = relatedProducts.Select(p => new GetRelatedProductDto
        {
            Id = p.Id,
            PictureUrl = string.IsNullOrEmpty(p.MediaUrl) ? null : $"{host}/{p.MediaUrl.TrimStart('/')}",
            Name = p.Name,
            Price = p.Price,
            HaveOffer = p.HaveOffer,
            DiscountPercentage = p.DiscountPercentage
        }).ToList();

        _memoryCache.Set(cacheKey, relatedDtos, new MemoryCacheEntryOptions
        {
            SlidingExpiration = TimeSpan.FromMinutes(10)
        });

        return ApiResponse<List<GetRelatedProductDto>>.SuccessResponse(relatedDtos,
    HttpStatusCode.OK,
    en: "Related products fetched successfully.",
    ar: "تم جلب المنتجات المرتبطة بنجاح.");

    }
}
