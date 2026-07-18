using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class ProductRecommendationService(
    IRecommendationService recommendationService,
    IUnitOfWork unitOfWork,
    IHttpContextAccessor httpContextAccessor,
    ILogger<ProductRecommendationService> logger
) : IProductRecommendationService
{
    private readonly IRecommendationService _recommendationService = recommendationService;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly ILogger<ProductRecommendationService> _logger = logger;

    public async Task<List<GetAllProductsResponse>> GetRecommendedProductsAsync(string? userId, int count = 10)
    {
        if (string.IsNullOrEmpty(userId))
        {
            _logger.LogInformation("No user ID provided, returning recently added products.");
            return await GetRecentlyAddedProductsAsync(count);
        }

        try
        {
            var reelIds = await _recommendationService.GetRecommendedReelIdsAsync(userId, count * 2);

            if (reelIds == null || reelIds.Count == 0)
            {
                _logger.LogInformation("No recommended reel IDs for user {UserId}, returning recently added products.", userId);
                return await GetRecentlyAddedProductsAsync(count);
            }

            var products = await GetProductsFromReelsAsync(reelIds, count);

            if (products.Count == 0)
            {
                _logger.LogInformation("No products found from recommended reels for user {UserId}, returning recently added products.", userId);
                return await GetRecentlyAddedProductsAsync(count);
            }

            return products;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching recommended products for user {UserId}, falling back to recently added.", userId);
            return await GetRecentlyAddedProductsAsync(count);
        }
    }

    private async Task<List<GetAllProductsResponse>> GetProductsFromReelsAsync(List<int> reelIds, int count)
    {
        var reelRepository = _unitOfWork.Repository<Reel>();
        var spec = new RecommendedProductsFromReelsSpec(reelIds);
        var reels = await reelRepository.GetAllWithSpecAsync(spec);

        var products = new List<Product>();
        var seenProductIds = new HashSet<int>();

        foreach (var reel in reels)
        {
            if (reel.ProductReels == null) continue;

            foreach (var pr in reel.ProductReels)
            {
                if (pr.Product != null && seenProductIds.Add(pr.Product.Id))
                {
                    products.Add(pr.Product);
                }
            }
        }

        return products
            .Take(count)
            .Select(MapToGetAllProductsResponse)
            .ToList();
    }

    private async Task<List<GetAllProductsResponse>> GetRecentlyAddedProductsAsync(int count)
    {
        var productRepository = _unitOfWork.Repository<Product>();
        var spec = new RecentlyAddedProductsSpec(count);
        var products = await productRepository.GetAllWithSpecAsync(spec);

        return products
            .Select(MapToGetAllProductsResponse)
            .ToList();
    }

    private string GetHostUrl()
    {
        var request = _httpContextAccessor.HttpContext?.Request;
        return $"{request?.Scheme}://{request?.Host.Value}";
    }

    private string BuildMediaUrl(string mediaUrl)
    {
        if (string.IsNullOrWhiteSpace(mediaUrl))
            return string.Empty;

        if (Uri.TryCreate(mediaUrl, UriKind.Absolute, out var uri) &&
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return mediaUrl;
        }

        return $"{GetHostUrl()}/{mediaUrl.TrimStart('/')}";
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
            MediaUrls = product.Images?
                        .Select(x => new ProductImageDto
                        {
                            Id = x.Id,
                            Url = BuildMediaUrl(x.Url)
                        })
                        .ToList() ?? new List<ProductImageDto>(),
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

    private static readonly Dictionary<int, int> _defaultRatingDistribution = new()
    {
        { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }
    };

    private ProductBrandDto MapToBrandDto(Brand brand)
    {
        if (brand == null) return null!;

        return new ProductBrandDto
        {
            Id = brand.Id,
            DisplayName = brand.DisplayName,
            Description = brand.Description,
            LogoUrl = brand.LogoUrl,
            FollowersCount = brand.UserFollows?.Count ?? 0,
            AverageRating = brand.Reviews?.Any() == true ? brand.Reviews.Average(r => r.Rating) : 0
        };
    }

    private ProductCategoryDto MapToCategoryDto(ProductCategory category)
    {
        if (category == null) return null!;

        return new ProductCategoryDto
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
            AvailableSizes = ac.AvailableSizes?.Select(s => new ProductSizeDto
            {
                Id = s.ProductSize?.Id ?? 0,
                Size = s.ProductSize?.Size.ToString() ?? "M",
                Quantity = s.Quantity
            }).ToList() ?? new List<ProductSizeDto>()
        }).ToList();
    }

    private ProductReviewsSummaryDto MapToReviewsSummary(ICollection<Domain.Entities.Reviews.ProductReview> reviews)
    {
        return new ProductReviewsSummaryDto
        {
            AverageRating = reviews?.Any() == true ? reviews.Average(r => r.Rating) : 0,
            TotalReviews = reviews?.Count ?? 0,
            RatingDistribution = reviews == null || !reviews.Any()
                ? new Dictionary<int, int>(_defaultRatingDistribution)
                : reviews
                    .GroupBy(r => r.Rating)
                    .ToDictionary(g => g.Key, g => g.Count())
                    .Concat(_defaultRatingDistribution.Where(kvp => !reviews.Any(r => r.Rating == kvp.Key)))
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
        };
    }
}
