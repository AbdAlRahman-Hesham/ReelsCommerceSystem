using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class ProductService(
    IMemoryCache memoryCache,
    IHttpContextAccessor httpContextAccessor,
    IUnitOfWork unitOfWork,
    IRelatedProductService relatedProductService
   

) : IProductService
{
    private readonly IGenericRepository<Product> _productRepository = unitOfWork.Repository<Product>();
    private static readonly TimeSpan _cacheExpiration = TimeSpan.FromMinutes(10);
   




    private static readonly Dictionary<int, int> _defaultRatingDistribution = new()
    {
        { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }
    };

    public async Task<ApiResponse<PaginationResponse<GetAllProductsResponse>>> GetProductsAsync(ProductSpecParams productSpecParams)
    {
        return await GetOrSetCacheAsync(
            GenerateCacheKey(productSpecParams),
            async () =>
            {
                var spec = new ProductSpec(productSpecParams);
                var products = await _productRepository.GetAllWithSpecAsync(spec);
                var totalCount = await _productRepository.CountAsync(spec);

                var productDtos = products.Select(MapToGetAllProductsResponse).ToList();

                var meta = CreatePaginationMeta(totalCount, spec);

                return PaginationResponse<GetAllProductsResponse>.SuccessResponse(
                    data: productDtos,
                    meta: meta,
                    statusCode: HttpStatusCode.OK
                );
            }
        );
    }
    public async Task<ApiResponse<PaginationResponse<GetAllProductsForAiResponse>>> GetAllProductsForAiAsync()
    {
        var productSpecParams = new ProductSpecParams
        {
            PageIndex = 1,
            PageSize = int.MaxValue
        };
        return await GetOrSetCacheAsync(
            GenerateCacheKey(productSpecParams),
            async () =>
            {
                var spec = new ProductSpec(productSpecParams);
                var products = await _productRepository.GetAllWithSpecAsync(spec);
                var totalCount = await _productRepository.CountAsync(spec);

                var productDtos = new List<GetAllProductsForAiResponse>();

                foreach (var product in products)
                {
                    var related = await relatedProductService.GetRelatedProductsAsync(product.Id);
                    productDtos.Add(MapToGetAllProductsFoAiResponse(product, related.Data ?? []));
                }

                var meta = CreatePaginationMeta(totalCount, spec);

                return PaginationResponse<GetAllProductsForAiResponse>.SuccessResponse(
                    data: productDtos,
                    meta: meta,
                    statusCode: HttpStatusCode.OK
                );
            }
        );
    }

    public async Task<ApiResponse<GetProductResponse>> GetProductAsync(int productId)
    {
        return await GetOrSetCacheAsync(
            $"product:{productId}",
            async () =>
            {
                var spec = new ProductByIdSpec(productId);
                var product = await _productRepository.GetWithSpecAsync(spec);

                if (product == null)
                {
                    return ApiResponse<GetProductResponse>.ErrorResponse(
                        HttpStatusCode.NotFound,
                        "Product not found.",
                        "المنتج غير موجود."
                    );
                }

                var relatedProducts = await relatedProductService.GetRelatedProductsAsync(productId);
                var productDto = MapToGetProductResponse(product, relatedProducts.Data ?? []);

                return ApiResponse<GetProductResponse>.SuccessResponse(
                    data: productDto,
                    statusCode: HttpStatusCode.OK
                );
            }
        );
    }

    public async Task<ApiResponse<List<ProductCategoryResponse>>> GetProductCategoriesAsync()
    {
        return await GetOrSetCacheAsync(
            "productCategories",
            async () =>
            {
                var categories = await unitOfWork.Repository<ProductCategory>().GetAllAsync();
                var categoryDtos = categories.Select(MapToCategoryResponse).ToList();

                return ApiResponse<List<ProductCategoryResponse>>.SuccessResponse(
                    data: categoryDtos,
                    statusCode: HttpStatusCode.OK
                );
            }
        );
    }
 

    #region Private Helper Methods

    private async Task<T> GetOrSetCacheAsync<T>(string cacheKey, Func<Task<T>> factory)
    {
        if (memoryCache.TryGetValue(cacheKey, out T cachedValue))
        {
            return cachedValue;
        }

        var value = await factory();
        var cacheOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(_cacheExpiration);
        memoryCache.Set(cacheKey, value, cacheOptions);

        return value;
    }

    private string GetHostUrl()
    {
        var request = httpContextAccessor.HttpContext?.Request;
        return $"{request?.Scheme}://{request?.Host.Value}";
    }

    private string BuildMediaUrl(string mediaUrl)
    {
        return string.IsNullOrEmpty(mediaUrl) ? "" : $"{GetHostUrl()}/{mediaUrl.TrimStart('/')}";
    }

    private GetAllProductsResponse MapToGetAllProductsResponse(Product product)
    {
        return new GetAllProductsResponse
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ArDescription = product.ArDescription,
            Price = product.Price,
            Quantity = product.Quantity,
            MediaUrl = BuildMediaUrl(product.MediaUrl),
            IsCustomizable = product.IsCustomizable,
            DiscountPercentage = product.DiscountPercentage,
            HaveOffer = product.HaveOffer,
            StockStatus = product.Status.ToString(),
            Brand = MapToBrandDto(product.Brand),
            Category = MapToCategoryDto(product.Category),
            ReviewsSummary = MapToReviewsSummary(product.Reviews),
            AvailableColors = MapToColorDtos(product.AvailableColors),

        };
    }
    private GetAllProductsForAiResponse MapToGetAllProductsFoAiResponse(Product product, List<GetRelatedProductDto> relatedProducts)
    {
        return new GetAllProductsForAiResponse
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ArDescription = product.ArDescription,
            Price = product.Price,
            Quantity = product.Quantity,
            MediaUrl = BuildMediaUrl(product.MediaUrl),
            IsCustomizable = product.IsCustomizable,
            DiscountPercentage = product.DiscountPercentage,
            HaveOffer = product.HaveOffer,
            StockStatus = product.Status.ToString(),
            Brand = MapToBrandDto(product.Brand),
            Category = MapToCategoryDto(product.Category),
            AvailableColors = MapToColorDtos(product.AvailableColors),
            ProductInformations = MapToProductInformationDtos(product.ProductInformations),
            ReviewsSummary = MapToReviewsSummary(product.Reviews),
            Reviews = MapToReviewDtos(product.Reviews),
            RelatedProducts = relatedProducts
        };
    }

    private GetProductResponse MapToGetProductResponse(Product product, List<GetRelatedProductDto> relatedProducts)
    {
        return new GetProductResponse
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ArDescription = product.ArDescription,
            Price = product.Price,
            Quantity = product.Quantity,
            MediaUrl = BuildMediaUrl(product.MediaUrl),
            IsCustomizable = product.IsCustomizable,
            DiscountPercentage = product.DiscountPercentage,
            HaveOffer = product.HaveOffer,
            StockStatus = product.Status.ToString(),
            Brand = MapToBrandDto(product.Brand),
            Category = MapToCategoryDto(product.Category),
            AvailableColors = MapToColorDtos(product.AvailableColors),
            ProductInformations = MapToProductInformationDtos(product.ProductInformations),
            ReviewsSummary = MapToReviewsSummary(product.Reviews),
            Reviews = MapToReviewDtos(product.Reviews),
            RelatedProducts = relatedProducts
        };
    }

    private ProductBrandDto MapToBrandDto(Brand brand)
    {
        if (brand == null) return null;

        return new ProductBrandDto
        {
            Id = brand.Id,
            DisplayName = brand.DisplayName,
            Description = brand.Description,
            LogoUrl = brand.LogoUrl,
            FollowersCount = brand.UserFollows?.Count ?? 0,
            AverageRating = CalculateAverageRating(brand.Reviews)
        };
    }

    private ProductCategoryDto MapToCategoryDto(ProductCategory category)
    {
        if (category == null) return null;

        return new ProductCategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            ArName = category.ArName
        };
    }

    private ProductCategoryResponse MapToCategoryResponse(ProductCategory category)
    {
        return new ProductCategoryResponse
        {
            Id = category.Id,
            Name = category.Name,
            ArName = category.ArName
        };
    }

    private List<ProductColorDto> MapToColorDtos(ICollection<ProductColorMapping> colorMappings)
    {
        if (colorMappings == null) return new List<ProductColorDto>();

        return colorMappings.Select(ac => new ProductColorDto
        {
            Id = ac.ProductColor?.Id ?? 0,
            Name = ac.ProductColor?.Name ?? "Unknown",
            ArName = ac.ProductColor?.ArName ?? "غير معروف",
            HexCode = ac.ProductColor?.HexCode ?? "#000000",
            Quantity = ac.Quantity,
            AvailableSizes = MapToSizeDtos(ac.AvailableSizes)

        }).ToList();
    }

    private List<ProductSizeDto> MapToSizeDtos(ICollection<ProductSizeMapping> sizeMappings)
    {
        if (sizeMappings == null) return new List<ProductSizeDto>();

        return sizeMappings.Select(asize => new ProductSizeDto
        {
            Id = asize.ProductSize?.Id ?? 0,
            Size = asize.ProductSize?.Size.ToString() ?? Size.M.ToString(),
            Quantity = asize.Quantity
        }).ToList();
    }

    private List<ProductInformationDto> MapToProductInformationDtos(ICollection<ProductInformation> productInformations)
    {
        if (productInformations == null) return new List<ProductInformationDto>();

        return productInformations.Select(pi => new ProductInformationDto
        {
            Id = pi.Id,
            Key = pi.Key,
            Value = pi.Value,
            ArKey = pi.ArKey,
            ArValue = pi.ArValue,
            Type = pi.Type.ToString(),
            Group = pi.Group,
            ArGroup = pi.ArGroup,
            DisplayOrder = pi.DisplayOrder
        }).ToList();
    }

    private ProductReviewsSummaryDto MapToReviewsSummary(ICollection<ProductReview> reviews)
    {
        return new ProductReviewsSummaryDto
        {
            AverageRating = CalculateAverageRating(reviews),
            TotalReviews = reviews?.Count ?? 0,
            RatingDistribution = CalculateRatingDistribution(reviews)
        };
    }

    private List<ProductReviewDto> MapToReviewDtos(ICollection<ProductReview> reviews)
    {
        return reviews?.Take(5)
            .Select(r => new ProductReviewDto
            {
                Id = r.Id,
                Rating = r.Rating,
                Comment = r.Comment,
                CreatedAt = r.CreatedAt,
                User = new UserDto
                {
                    Id = r.User?.Id ?? string.Empty,
                    UserName = r.User?.UserName ?? "Unknown User",
                    ProfilePictureUrl = r.User?.ImageURL
                }
            }).ToList() ?? new List<ProductReviewDto>();
    }

    private static double CalculateAverageRating(ICollection<ProductReview> reviews)
    {
        return reviews?.Any() == true ? reviews.Average(r => r.Rating) : 0;
    }

    private static double CalculateAverageRating(ICollection<BrandReview> reviews)
    {
        return reviews?.Any() == true ? reviews.Average(r => r.Rating) : 0;
    }

    private static Dictionary<int, int> CalculateRatingDistribution(ICollection<ProductReview> reviews)
    {
        if (reviews == null || !reviews.Any())
            return new Dictionary<int, int>(_defaultRatingDistribution);

        return reviews
            .GroupBy(r => r.Rating)
            .ToDictionary(g => g.Key, g => g.Count())
            .Concat(_defaultRatingDistribution.Where(kvp => !reviews.Any(r => r.Rating == kvp.Key)))
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }

    private static Meta CreatePaginationMeta<T>(int totalCount, Specification<T> spec) where T : BaseEntity
    {
        var currentPage = spec.PageIndex ?? 1;
        var size = spec.PageSize ?? totalCount;
        var totalPages = spec.GetTotalPages(totalCount);

        return new Meta
        {
            PageNumber = currentPage,
            PageSize = size,
            TotalRecords = totalCount,
            HasPreviousPage = spec.HasPreviousPage(),
            HasNextPage = spec.HasNextPage(totalCount)
        };
    }


    private static string GenerateCacheKey(ProductSpecParams p)
    {
        return $"products:" +
               $"search={p.Search ?? ""};" +
               $"color={p.Color ?? ""};" +
               $"size={p.Size ?? ""};" +
               $"status={p.StockStatus ?? ""};" +
               $"min={p.MinPrice?.ToString() ?? ""};" +
               $"max={p.MaxPrice?.ToString() ?? ""};" +
               $"haveOffer={p.HaveOffer?.ToString() ?? ""};" +
               $"sort={p.SortBy ?? ""};" +
               $"sortOrder={p.SortOrder ?? ""};" +
               $"pageIndex={p.PageIndex ?? 1};" +
               $"pageSize={p.PageSize ?? 10};";
    }

    #endregion
}