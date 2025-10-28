using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Repositories;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.SpecificationsParams;


namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _genericRepository;
        private readonly IMemoryCache _memoryCache;

        public ProductService(IGenericRepository<Product> genericRepository,IMemoryCache memoryCache)
        {
            _genericRepository = genericRepository;
            _memoryCache = memoryCache;
        }
        public async Task<ApiResponse<PaginationResponse<ProductPag>>> GetProductsAsync(ProductSpecParams productSpecParams)
        {
            var cacheKey = GenerateCacheKey(productSpecParams);
            if(_memoryCache.TryGetValue(cacheKey, out ApiResponse<PaginationResponse<ProductPag>> cachedResponse))
            {
                return cachedResponse;
            }
            var spec = new ProductSpec(productSpecParams);
  
            var products = await _genericRepository.GetAllWithSpecAsync(spec);
            var totalCount = await _genericRepository.CountAsync(spec);

            var productDtos = products.Select(p => new ProductPag
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Category = p.Category,
                Price = p.Price,
                MediaUrl = p.MediaUrl,
                Color = p.Color,
                Size = p.Size,
                HaveOffer = p.HaveOffer,
                DiscountPercentage = p.DiscountPercentage,
                Status = p.Status,
                BrandName = p.Brand != null ? p.Brand.DisplayName : "Unknown"
            }).ToList();
            var meta = new Meta
            {
                PageNumber = productSpecParams.PageIndex ?? 1,
                PageSize = productSpecParams.PageSize ?? totalCount,
                TotalRecords = totalCount,
                HasPreviousPage = (productSpecParams.PageIndex ?? 1) > 1,
                HasNextPage = (productSpecParams.PageIndex ?? 1) * (productSpecParams.PageSize ?? totalCount) < totalCount
            };

            var response= PaginationResponse<ProductPag>.SuccessResponse(
                data: productDtos,
                meta: meta,
                statusCode: HttpStatusCode.OK
            );
            var cacheOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(10));
            _memoryCache.Set(cacheKey, response, cacheOptions);
            return response;

        }
        private static string GenerateCacheKey(ProductSpecParams p)
        {
          
            string key = $"products:" +
                $"search={p.Search ?? ""};" +
                $"color={p.Color ?? ""};" +
                $"size={p.Size ?? ""};" +
                $"status={p.Status ?? ""};" +
                $"min={p.MinPrice?.ToString() ?? ""};" +
                $"max={p.MaxPrice?.ToString() ?? ""};" +
                $"haveOffer={p.HaveOffer?.ToString() ?? ""};" +
                $"sort={p.Sort ?? ""};" +
                $"pageIndex={p.PageIndex ?? 1};" +
                $"pageSize={p.PageSize ?? 10};";
            return key;
        }
    }
}
