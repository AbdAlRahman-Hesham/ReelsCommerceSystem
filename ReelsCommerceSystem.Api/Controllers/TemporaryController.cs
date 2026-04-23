using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Api.Controllers;

public class TemporaryController(AppDbContext _db) : AppBaseController
{
    [HttpGet]
    public async Task<IActionResult> GetReels()
    {
        var reels = await _db.Reels
            .Include(r => r.Brand)
            .Include(r => r.ProductReels)
                .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Category)
            .Include(r => r.ProductReels)
                .ThenInclude(pr => pr.Product)
                    .ThenInclude(p => p.Brand)
            .Include(r => r.UserReelLikes)
                .ThenInclude(l => l.User)
            .Include(r => r.UserReelViews)
                .ThenInclude(v => v.User)
            .Include(r => r.ReelComments)
                .ThenInclude(c => c.User)
            .Include(r => r.ReelComments)
                .ThenInclude(c => c.Loves)
                    .ThenInclude(l => l.User)
            .Include(r => r.ReelComments)
                .ThenInclude(c => c.Replies)
                    .ThenInclude(rep => rep.User)
            .Include(r => r.ReelComments)
                .ThenInclude(c => c.Replies)
                    .ThenInclude(rep => rep.Loves)
                        .ThenInclude(l => l.User)
            .AsNoTracking()
            .ToListAsync();

        var result = new
        {
            reels = reels.Select(r => new
            {
                r.Id,
                r.Title,
                r.VideoUrl,
                r.BrandId,
                r.CreatedAt,
                numOfLikes = r.UserReelLikes.Count,
                numOfWatches = r.UserReelViews.Count,
                brand = r.Brand == null ? null : new
                {
                    r.Brand.Id,
                    r.Brand.DisplayName,
                    r.Brand.Description,
                    r.Brand.LogoUrl,
                    verificationStatus = r.Brand.Status == BrandStatus.APPROVED ? "Verified" : r.Brand.Status.ToString()
                },
                productReels = r.ProductReels.Select(pr => new
                {
                    pr.Id,
                    pr.ProductId,
                    product = pr.Product == null ? null : new
                    {
                        pr.Product.Id,
                        pr.Product.Name,
                        price = (double)pr.Product.Price,
                        category = pr.Product.Category == null ? (string?)null : pr.Product.Category.Name,
                        pr.Product.BrandId,
                        brandName = pr.Product.Brand == null ? (string?)null : pr.Product.Brand.DisplayName
                    }
                }),
                userReelLikes = r.UserReelLikes.Select(l => new
                {
                    l.Id,
                    l.UserId,
                    l.CreatedAt,
                    user = l.User == null ? null : new
                    {
                        l.User.Id,
                        userName = l.User.UserName,
                        l.User.DisplayName,
                        l.User.ImageURL
                    }
                }),
                userReelViews = r.UserReelViews.Select(v => new
                {
                    v.Id,
                    v.UserId,
                    viewedAt = v.CreatedAt,
                    v.WatchedDurationSeconds,
                    v.VideoDurationSeconds,
                    v.WatchRatio,
                    user = v.User == null ? null : new
                    {
                        v.User.Id,
                        userName = v.User.UserName,
                        v.User.DisplayName
                    }
                }),
                reelComments = r.ReelComments.Select(c => new
                {
                    c.Id,
                    c.Content,
                    c.CreatedAt,
                    c.UserId,
                    user = c.User == null ? null : new
                    {
                        c.User.Id,
                        userName = c.User.UserName,
                        c.User.DisplayName,
                        c.User.ImageURL
                    },
                    loves = c.Loves.Select(l => new
                    {
                        l.Id,
                        l.UserId,
                        l.CreatedAt,
                        user = l.User == null ? null : new
                        {
                            l.User.Id,
                            userName = l.User.UserName,
                            l.User.DisplayName
                        }
                    }),
                    replies = c.Replies.Select(rep => new
                    {
                        rep.Id,
                        rep.Content,
                        rep.CreatedAt,
                        rep.UserId,
                        user = rep.User == null ? null : new
                        {
                            rep.User.Id,
                            userName = rep.User.UserName,
                            rep.User.DisplayName
                        },
                        loves = rep.Loves.Select(l => new
                        {
                            l.Id,
                            l.UserId,
                            l.CreatedAt,
                            user = l.User == null ? null : new
                            {
                                l.User.Id,
                                userName = l.User.UserName,
                                l.User.DisplayName
                            }
                        })
                    })
                })
            })
        };

        return Ok(result);
    }

    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _db.Users
            .Select(u => new
            {
                id = u.Id,
                userReelViews = u.UserReelViews.Select(v => new
                {
                    reelId = v.ReelId,
                    watchRatio = v.VideoDurationSeconds <= 0
                        ? 0.0
                        : Math.Min(1.0, (double)v.WatchedDurationSeconds / v.VideoDurationSeconds)
                }),
                userReelLikes = u.UserReelLikes.Select(l => new
                {
                    reelId = l.ReelId
                }),
                reelComments = u.ReelComments.Select(c => new
                {
                    reelId = c.ReelId,
                    content = c.Content
                })
            })
            .AsNoTracking()
            .ToListAsync();

        return Ok(users);
    }

    [HttpGet("encrypt")]
    public async Task<IActionResult> Encrypt(string text)
    {
        return Ok(EncryptionHelper.Encrypt(text));

    }
    [HttpGet("decrypt")]
    public async Task<IActionResult> Decrypt(string encText)
    {
        return Ok(EncryptionHelper.Decrypt(encText));

    }
}
