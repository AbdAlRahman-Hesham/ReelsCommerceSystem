using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
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
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IGenericRepository<Product> _productRepository = unitOfWork.Repository<Product>();
    private static readonly TimeSpan _cacheExpiration = TimeSpan.FromMinutes(10);
   




    private static readonly Dictionary<int, int> _defaultRatingDistribution = new()
    {
        { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }
    };

    public async Task<ApiResponse<PaginationResponse<GetAllProductsResponse>>> GetProductsAsync(ProductSpecParams productSpecParams)
    {
        var userId = httpContextAccessor.HttpContext?.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var cacheKey = GenerateCacheKey(productSpecParams);

        var (products, meta) = await GetOrSetCacheAsync(
            cacheKey,
            async () =>
            {
                var spec = new ProductSpec(productSpecParams);
                var products = await _productRepository.GetAllWithSpecAsync(spec);
                var totalCount = await _productRepository.CountAsync(spec);
                var meta = CreatePaginationMeta(totalCount, spec);

                return (products, meta);
            }
        );

        var productDtos = products.Select(MapToGetAllProductsResponse).ToList();

        // If user is authenticated, mark wishlist status for each product
        if (!string.IsNullOrEmpty(userId))
        {
            var wishlistSpec = new ReelsCommerceSystem.Infrastructure.Specifications.Specifications.WishlistSpec.WishlistItemSpec(userId);
            var wishlistItems = await unitOfWork.Repository<ReelsCommerceSystem.Domain.Entities.Order_ProductEntities.WishlistItem>().GetAllWithSpecAsync(wishlistSpec);
            var lovedIds = wishlistItems?.Select(w => w.ProductId).ToHashSet() ?? new HashSet<int>();

            foreach (var dto in productDtos)
            {
                dto.IsInWishlist = lovedIds.Contains(dto.Id);
            }
        }

        return PaginationResponse<GetAllProductsResponse>.SuccessResponse(
            data: productDtos,
            meta: meta,
            statusCode: HttpStatusCode.OK
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
        var userId = httpContextAccessor.HttpContext?.User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        var cacheKey = $"product:{productId}";

        var product = await GetOrSetCacheAsync(
            cacheKey,
            async () =>
            {
                var spec = new ProductByIdSpec(productId);
                return await _productRepository.GetWithSpecAsync(spec);
            }
        );

        if (product == null)
        {
            return ApiResponse<GetProductResponse>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Product not found.",
                "المنتج غير موجود."
            );
        }

        var relatedProducts = await relatedProductService.GetRelatedProductsAsync(productId);
        var productDto = MapToGetProductResponse(product, relatedProducts.Data ?? new List<GetRelatedProductDto>());

        // mark wishlist status
        if (!string.IsNullOrEmpty(userId))
        {
            var specWish = new ReelsCommerceSystem.Infrastructure.Specifications.Specifications.WishlistSpec.WishlistItemSpec(userId, productId);
            var wishItem = await unitOfWork.Repository<ReelsCommerceSystem.Domain.Entities.Order_ProductEntities.WishlistItem>().GetWithSpecAsync(specWish);
            productDto.IsInWishlist = wishItem != null;
        }

        return ApiResponse<GetProductResponse>.SuccessResponse(
            data: productDto,
            statusCode: HttpStatusCode.OK
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
            ArName = category.ArName,
            ImageUrl = category.ImageUrl
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
               $"categoryIds={(p.CategoryIds != null ? string.Join(",", p.CategoryIds) : "")};" +
               $"color={(p.Colors != null ? string.Join(",", p.Colors) : "")};" +
               $"size={(p.Sizes != null ? string.Join(",", p.Sizes) : "")};" +
               $"status={p.StockStatus ?? ""};" +
               $"brandId={p.BrandId ?? 0};" +   
               $"min={p.MinPrice?.ToString() ?? ""};" +
               $"max={p.MaxPrice?.ToString() ?? ""};" +
               $"haveOffer={p.HaveOffer?.ToString() ?? ""};" +
               $"sort={p.SortBy ?? ""};" +
               $"sortOrder={p.SortOrder ?? ""};" +
               $"pageIndex={p.PageIndex ?? 1};" +
               $"pageSize={p.PageSize ?? 10};";
    }

    #endregion

    #region Product Reviews

    public async Task<ApiResponse<string>> AddOrUpdateProductReview(int productId, string userId, ProductReviewReq dto)
    {
        var product = await _unitOfWork.Repository<Product>().GetByIdAsync(productId);
        if (product == null)
        {
            return ApiResponse<string>.ErrorResponse(HttpStatusCode.NotFound, "Product not found.", "المنتج غير موجود.");
        }

        var existingReview = await _unitOfWork.Repository<ProductReview>().GetWithSpecAsync(new ProductReviewByUserSpec(productId, userId));

        HttpStatusCode statusCode;
        string enMessage;
        string arMessage;

        if (existingReview == null)
        {
            var review = new ProductReview
            {
                ProductId = productId,
                UserId = userId,
                Rating = dto.Rating,
                Comment = dto.Comment
            };

            await _unitOfWork.Repository<ProductReview>().AddAsync(review);

            product.AverageRating = (product.AverageRating * product.NumOfReviews + dto.Rating) / (product.NumOfReviews + 1);
            product.NumOfReviews += 1;

            statusCode = HttpStatusCode.Created;
            enMessage = "Review added successfully.";
            arMessage = "تم إضافة التقييم بنجاح.";
        }
        else
        {
            int oldRating = existingReview.Rating;
            existingReview.Rating = dto.Rating;
            existingReview.Comment = dto.Comment;

            _unitOfWork.Repository<ProductReview>().Update(existingReview);

            product.AverageRating = (product.AverageRating * product.NumOfReviews - oldRating + dto.Rating) / product.NumOfReviews;

            statusCode = HttpStatusCode.OK;
            enMessage = "Review updated successfully.";
            arMessage = "تم تعديل التقييم بنجاح.";
        }

        _unitOfWork.Repository<Product>().Update(product);
        await _unitOfWork.SaveChangesAsync();

        return ApiResponse<string>.SuccessResponse("Success", statusCode, enMessage, arMessage);
    }

    public async Task<ProductToggleLikeRes> ProductReviewLikeAsync(string userId, ProductToggleLikeReq req)
    {
        var review = await _unitOfWork.Repository<ProductReview>().GetByIdAsync(req.ReviewId);
        if (review == null)
            throw new Exception("Review not found.");

        var reviewLike = await _unitOfWork.Repository<ProductReviewLike>().GetWithSpecAsync(new ProductReviewLikeSpec(userId, req));

        bool isLiked;

        if (reviewLike == null)
        {
            var newLike = new ProductReviewLike
            {
                ReviewId = req.ReviewId,
                UserId = userId
            };

            await _unitOfWork.Repository<ProductReviewLike>().AddAsync(newLike);
            review.NumOfLikes += 1;
            isLiked = true;
        }
        else
        {
            _unitOfWork.Repository<ProductReviewLike>().Delete(reviewLike);
            review.NumOfLikes = Math.Max(0, review.NumOfLikes - 1);
            isLiked = false;
        }

        _unitOfWork.Repository<ProductReview>().Update(review);
        await _unitOfWork.SaveChangesAsync();

        return new ProductToggleLikeRes
        {
            ReviewId = req.ReviewId,
            IsLiked = isLiked,
            TotalLikes = review.NumOfLikes
        };
    }

    public async Task<ProductToggleDislikeRes> ProductReviewDislikeAsync(string userId, ProductToggleDislikeReq req)
    {
        var review = await _unitOfWork.Repository<ProductReview>().GetByIdAsync(req.ReviewId);
        if (review == null)
            throw new Exception("Review not found.");

        var reviewDislike = await _unitOfWork.Repository<ProductReviewDislike>().GetWithSpecAsync(new ProductReviewDislikeSpec(userId, req));

        bool isDisliked;

        if (reviewDislike == null)
        {
            var newDislike = new ProductReviewDislike
            {
                ReviewId = req.ReviewId,
                UserId = userId
            };

            await _unitOfWork.Repository<ProductReviewDislike>().AddAsync(newDislike);
            review.NumOfDislikes += 1;
            isDisliked = true;
        }
        else
        {
            _unitOfWork.Repository<ProductReviewDislike>().Delete(reviewDislike);
            review.NumOfDislikes = Math.Max(0, review.NumOfDislikes - 1);
            isDisliked = false;
        }

        _unitOfWork.Repository<ProductReview>().Update(review);
        await _unitOfWork.SaveChangesAsync();

        return new ProductToggleDislikeRes
        {
            ReviewId = req.ReviewId,
            IsDisliked = isDisliked,
            TotalDislikes = review.NumOfDislikes
        };
    }

    public async Task<ApiResponse<double>> GetProductAverageRating(int productId)
    {
        var product = await _unitOfWork.Repository<Product>().GetByIdAsync(productId);
        if (product == null)
            return ApiResponse<double>.ErrorResponse(HttpStatusCode.NotFound, "Product not found.", "المنتج غير موجود.");

        double avg = product.NumOfReviews > 0 ? product.AverageRating : 0;
        return ApiResponse<double>.SuccessResponse(avg, HttpStatusCode.OK);
    }

    #endregion
}