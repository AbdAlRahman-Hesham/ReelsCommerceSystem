using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class RelatedProductService : IRelatedProductService
    {
        private readonly IGenericRepository<Product> _genericRepository;
        private readonly IMemoryCache _memoryCache;

        public RelatedProductService(IGenericRepository<Product> genericRepository,IMemoryCache memoryCache)
        {
            _genericRepository = genericRepository;
            _memoryCache = memoryCache;
        }
     
        public async Task<ApiResponse<List<ProductPag>>> GetRelatedProductsAsync(int currentProductId, int take = 3)
        {
            string cacheKey = $"relatedProducts:{currentProductId}";

            if (_memoryCache.TryGetValue(cacheKey, out List<ProductPag> cachedProducts))
            {
                return ApiResponse<List<ProductPag>>.SuccessResponse(
                    cachedProducts,
                    HttpStatusCode.OK,
                    en: "Fetched from cache successfully.",
                    ar: "تم جلب المنتجات من الذاكرة المؤقتة بنجاح."
                );
            }

            var product = await _genericRepository.GetByIdAsync(currentProductId);
            if (product == null)
            {
                return ApiResponse<List<ProductPag>>.ErrorResponse(HttpStatusCode.NotFound,
                    en: "Product not found.",
                    ar: "المنتج غير موجود.");
            }

            var relatedProducts = (await _genericRepository.GetAllAsync())
                    .Where(p => p.Category != null &&
                   p.Category.ToLower() == product.Category.ToLower() &&
                   p.Id != currentProductId)
                   .Take(take)
                  .ToList();

            var relatedDtos = relatedProducts.Select(p => new ProductPag
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Category = p.Category,
                Description = p.Description,
                MediaUrl = p.MediaUrl,
                Color = p.Color,
                Size = p.Size,
                HaveOffer = p.HaveOffer,
                DiscountPercentage = p.DiscountPercentage,
                Status = p.Status,
                BrandName = p.Brand != null ? p.Brand.DisplayName : "Unknown"
            }).ToList();

            _memoryCache.Set(cacheKey, relatedDtos, new MemoryCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromMinutes(10)
            });

            return ApiResponse<List<ProductPag>>.SuccessResponse(relatedDtos,
        HttpStatusCode.OK,
        en: "Related products fetched successfully.",
        ar: "تم جلب المنتجات المرتبطة بنجاح.");

        }
    }
}
