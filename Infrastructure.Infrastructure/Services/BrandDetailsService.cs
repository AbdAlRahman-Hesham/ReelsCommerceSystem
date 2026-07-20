using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class BrandDetailsService : IBrandDetailsService
{
    private readonly AppDbContext _dbContext;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPhotoServive _photoService;

    public BrandDetailsService(AppDbContext dbContext, IUnitOfWork unitOfWork, IPhotoServive photoService)
    {
        _dbContext = dbContext;
        _unitOfWork = unitOfWork;
        _photoService = photoService;
    }

    public async Task<ApiResponse<BrandDetailsResponse>> GetBrandDetailsAsync(int brandId, string? currentUserId = null)
    {
        var spec = new GetBrandDetailsFullSpec(brandId);
        var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(spec);

        if (brand == null)
        {
            return ApiResponse<BrandDetailsResponse>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found.",
                "العلامة التجارية غير موجودة.");
        }

        var productsCount = await _dbContext.Products.CountAsync(p => p.BrandId == brandId);
        var reelsCount = await _dbContext.Reels.CountAsync(r => r.BrandId == brandId);

        var isVerified = brand.BrandVerification != null;
        var contactPhone = brand.BrandVerification?.PhoneNumber;

        var result = new BrandDetailsResponse
        {
            Id = brand.Id,
            DisplayName = brand.DisplayName,
            Description = brand.Description,
            LogoUrl = brand.LogoUrl,
            CoverImageUrl = brand.CoverImageUrl,
            ReturnPolicyAsHtml = brand.ReturnPolicyAsHtml,
            Category = brand.Category,
            Country = brand.Country,
            Governorate = brand.Governorate,
            District = brand.District,
            NumberOfEmployees = brand.NumberOfEmployees,
            Status = brand.Status.ToString(),
            CreatedAt = brand.CreatedAt,
            SubmittedAt = brand.SubmittedAt,
            AverageRating = brand.AverageRating,
            NumOfReviews = brand.NumOfReviews,
            IsVerified = isVerified,
            FollowersCount = brand.UserFollows?.Count ?? 0,
            ProductsCount = productsCount,
            ReelsCount = reelsCount,
            ContactPhone = contactPhone,
            PayoutPhoneNumber = brand.PayoutPhoneNumber,
            BankAccountNumber = brand.BankAccountNumber,
            Owner = new BrandOwnerDetails
            {
                UserId = brand.UserId,
                DisplayName = brand.user?.DisplayName ?? string.Empty,
                ImageUrl = brand.user?.ImageURL ?? string.Empty,
                Email = brand.user?.Email,
                PhoneNumber = contactPhone
            },
            SocialLinks = brand.SocialLinks?.Select(sl => new SocialLinkDto
            {
                Id = sl.Id,
                Platform = sl.Platform,
                Url = sl.Url
            }).ToList() ?? new()
        };

        return ApiResponse<BrandDetailsResponse>.SuccessResponse(result, HttpStatusCode.OK);
    }

    public async Task<ApiResponse<BrandDetailsResponse>> UpdateBrandDetailsAsync(int brandId, string userId, UpdateBrandDetailsReq dto)
    {
        var brand = await _dbContext.Brands
            .AsTracking()
            .IgnoreQueryFilters()
            .Include(b => b.SocialLinks)
            .FirstOrDefaultAsync(b => b.Id == brandId);

        if (brand == null)
        {
            return ApiResponse<BrandDetailsResponse>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found.",
                "العلامة التجارية غير موجودة.");
        }

        if (brand.UserId != userId)
        {
            return ApiResponse<BrandDetailsResponse>.ErrorResponse(
                HttpStatusCode.Forbidden,
                "You are not authorized to update this brand.",
                "ليس لديك صلاحية لتعديل هذه العلامة التجارية.");
        }

        brand.DisplayName = dto.DisplayName;
        brand.Description = dto.Description;
        brand.ReturnPolicyAsHtml = dto.ReturnPolicyAsHtml;
        brand.Category = dto.Category;
        brand.Country = dto.Country;
        brand.Governorate = dto.Governorate;
        brand.District = dto.District;
        brand.NumberOfEmployees = dto.NumberOfEmployees;
        brand.PayoutPhoneNumber = dto.PayoutPhoneNumber;
        brand.BankAccountNumber = dto.BankAccountNumber;
        brand.BankCode = dto.BankCode;

        var existingLinks = brand.SocialLinks?.ToList() ?? new();
        var incomingIds = dto.SocialLinks.Where(sl => sl.Id.HasValue).Select(sl => sl.Id!.Value).ToHashSet();

        foreach (var link in existingLinks)
        {
            if (!incomingIds.Contains(link.Id))
            {
                _dbContext.BrandSocialLinks.Remove(link);
            }
        }

        foreach (var linkDto in dto.SocialLinks)
        {
            if (linkDto.Id.HasValue)
            {
                var existing = existingLinks.FirstOrDefault(l => l.Id == linkDto.Id.Value);
                if (existing != null)
                {
                    existing.Platform = linkDto.Platform;
                    existing.Url = linkDto.Url;
                }
            }
            else
            {
                brand.SocialLinks.Add(new BrandSocialLink
                {
                    BrandId = brandId,
                    Platform = linkDto.Platform,
                    Url = linkDto.Url
                });
            }
        }

        await _dbContext.SaveChangesAsync();

        return await GetBrandDetailsAsync(brandId, userId);
    }

    public async Task<ApiResponse<List<TopEngagedUserDto>>> GetTopEngagedUsersAsync(int brandId, int count = 10)
    {
        var brandExists = await _dbContext.Brands.AnyAsync(b => b.Id == brandId);
        if (!brandExists)
        {
            return ApiResponse<List<TopEngagedUserDto>>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found.",
                "العلامة التجارية غير موجودة.");
        }

        var brandReelIds = await _dbContext.Reels
            .Where(r => r.BrandId == brandId)
            .Select(r => r.Id)
            .ToListAsync();

        var brandProductIds = await _dbContext.Products
            .Where(p => p.BrandId == brandId)
            .Select(p => p.Id)
            .ToListAsync();

        var followers = await _dbContext.UserBrandFollows
            .Where(f => f.BrandId == brandId)
            .Select(f => f.UserId)
            .ToHashSetAsync();

        var orderCounts = await _dbContext.OrderProducts
            .Where(op => op.BrandId == brandId)
            .GroupBy(op => op.Order.UserId)
            .Select(g => new { UserId = g.Key, Count = g.Count() })
            .ToDictionaryAsync(g => g.UserId, g => g.Count);

        var reelViewCounts = brandReelIds.Count > 0
            ? await _dbContext.Set<UserReelView>()
                .Where(rv => brandReelIds.Contains(rv.ReelId))
                .GroupBy(rv => rv.UserId)
                .Select(g => new { UserId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(g => g.UserId, g => g.Count)
            : new Dictionary<string, int>();

        var reelLikeCounts = brandReelIds.Count > 0
            ? await _dbContext.Set<UserReelLike>()
                .Where(rl => brandReelIds.Contains(rl.ReelId))
                .GroupBy(rl => rl.UserId)
                .Select(g => new { UserId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(g => g.UserId, g => g.Count)
            : new Dictionary<string, int>();

        var commentCounts = brandReelIds.Count > 0
            ? await _dbContext.Set<ReelComment>()
                .Where(rc => brandReelIds.Contains(rc.ReelId))
                .GroupBy(rc => rc.UserId)
                .Select(g => new { UserId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(g => g.UserId, g => g.Count)
            : new Dictionary<string, int>();

        var wishlistCounts = brandProductIds.Count > 0
            ? await _dbContext.Set<WishlistItem>()
                .Where(wi => brandProductIds.Contains(wi.ProductId))
                .GroupBy(wi => wi.UserId)
                .Select(g => new { UserId = g.Key, Count = g.Count() })
                .ToDictionaryAsync(g => g.UserId, g => g.Count)
            : new Dictionary<string, int>();

        var allUserIds = orderCounts.Keys
            .Union(reelViewCounts.Keys)
            .Union(reelLikeCounts.Keys)
            .Union(commentCounts.Keys)
            .Union(wishlistCounts.Keys)
            .Union(followers)
            .Distinct()
            .ToList();

        if (allUserIds.Count == 0)
        {
            return ApiResponse<List<TopEngagedUserDto>>.SuccessResponse(new(), HttpStatusCode.OK);
        }

        var users = await _dbContext.Users
            .Where(u => allUserIds.Contains(u.Id))
            .Select(u => new { u.Id, u.DisplayName, u.ImageURL })
            .ToDictionaryAsync(u => u.Id);

        var engagedUsers = allUserIds
            .Select(uid =>
            {
                var orders = orderCounts.GetValueOrDefault(uid, 0);
                var views = reelViewCounts.GetValueOrDefault(uid, 0);
                var likes = reelLikeCounts.GetValueOrDefault(uid, 0);
                var comments = commentCounts.GetValueOrDefault(uid, 0);
                var wishlist = wishlistCounts.GetValueOrDefault(uid, 0);
                var isFollowing = followers.Contains(uid);

                var score = (orders * 5.0)
                    + (views * 1.0)
                    + (likes * 3.0)
                    + (comments * 4.0)
                    + (wishlist * 2.0)
                    + (isFollowing ? 3.0 : 0);

                var user = users.GetValueOrDefault(uid);

                return new TopEngagedUserDto
                {
                    UserId = uid,
                    DisplayName = user?.DisplayName ?? "Unknown",
                    ImageUrl = user?.ImageURL ?? string.Empty,
                    EngagementScore = score,
                    OrdersCount = orders,
                    ReelViewsCount = views,
                    ReelLikesCount = likes,
                    CommentsCount = comments,
                    WishlistItemsCount = wishlist,
                    IsFollowing = isFollowing
                };
            })
            .OrderByDescending(u => u.EngagementScore)
            .Take(count)
            .ToList();

        return ApiResponse<List<TopEngagedUserDto>>.SuccessResponse(engagedUsers, HttpStatusCode.OK);
    }

    public async Task<ApiResponse<string>> UploadLogoAsync(int brandId, string userId, IFormFile file)
    {
        var brand = await _dbContext.Brands.AsTracking().FirstOrDefaultAsync(b => b.Id == brandId);
        if (brand == null)
            return ApiResponse<string>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found.", "العلامة التجارية غير موجودة.");

        if (brand.UserId != userId)
            return ApiResponse<string>.ErrorResponse(HttpStatusCode.Forbidden, "You are not authorized.", "ليس لديك صلاحية.");

        if (!string.IsNullOrWhiteSpace(brand.LogoPublicId))
            await _photoService.DeleteImageAsync(brand.LogoPublicId);

        var uploadResult = await _photoService.UploadImageForProductAsync(file);

        brand.LogoUrl = uploadResult.Url;
        brand.LogoPublicId = uploadResult.PublicId;
        await _dbContext.SaveChangesAsync();

        return ApiResponse<string>.SuccessResponse(uploadResult.Url, HttpStatusCode.OK, "Logo uploaded", "تم رفع الشعار");
    }

    public async Task<ApiResponse<string>> UploadCoverAsync(int brandId, string userId, IFormFile file)
    {
        var brand = await _dbContext.Brands.AsTracking().FirstOrDefaultAsync(b => b.Id == brandId);
        if (brand == null)
            return ApiResponse<string>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found.", "العلامة التجارية غير موجودة.");

        if (brand.UserId != userId)
            return ApiResponse<string>.ErrorResponse(HttpStatusCode.Forbidden, "You are not authorized.", "ليس لديك صلاحية.");

        if (!string.IsNullOrWhiteSpace(brand.CoverPublicId))
            await _photoService.DeleteImageAsync(brand.CoverPublicId);

        var uploadResult = await _photoService.UploadImageForProductAsync(file);

        brand.CoverImageUrl = uploadResult.Url;
        brand.CoverPublicId = uploadResult.PublicId;
        await _dbContext.SaveChangesAsync();

        return ApiResponse<string>.SuccessResponse(uploadResult.Url, HttpStatusCode.OK, "Cover uploaded", "تم رفع الغلاف");
    }

    public async Task<ApiResponse<bool>> DeleteLogoAsync(int brandId, string userId)
    {
        var brand = await _dbContext.Brands.AsTracking().FirstOrDefaultAsync(b => b.Id == brandId);
        if (brand == null)
            return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found.", "العلامة التجارية غير موجودة.");

        if (brand.UserId != userId)
            return ApiResponse<bool>.ErrorResponse(HttpStatusCode.Forbidden, "You are not authorized.", "ليس لديك صلاحية.");

        if (!string.IsNullOrWhiteSpace(brand.LogoPublicId))
            await _photoService.DeleteImageAsync(brand.LogoPublicId);

        brand.LogoUrl = string.Empty;
        brand.LogoPublicId = null;
        await _dbContext.SaveChangesAsync();

        return ApiResponse<bool>.SuccessResponse(true, HttpStatusCode.OK, "Logo deleted", "تم حذف الشعار");
    }

    public async Task<ApiResponse<bool>> DeleteCoverAsync(int brandId, string userId)
    {
        var brand = await _dbContext.Brands.AsTracking().FirstOrDefaultAsync(b => b.Id == brandId);
        if (brand == null)
            return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Brand not found.", "العلامة التجارية غير موجودة.");

        if (brand.UserId != userId)
            return ApiResponse<bool>.ErrorResponse(HttpStatusCode.Forbidden, "You are not authorized.", "ليس لديك صلاحية.");

        if (!string.IsNullOrWhiteSpace(brand.CoverPublicId))
            await _photoService.DeleteImageAsync(brand.CoverPublicId);

        brand.CoverImageUrl = null;
        brand.CoverPublicId = null;
        await _dbContext.SaveChangesAsync();

        return ApiResponse<bool>.SuccessResponse(true, HttpStatusCode.OK, "Cover deleted", "تم حذف الغلاف");
    }
}
