using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Dashboard;
using ReelsCommerceSystem.Application.DTOs.Response.Order;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Entities.OrderProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.Products;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.DashboardSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class DashboardService : IDashboardService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly UserManager<User> _userManager;

    public DashboardService(IUnitOfWork unitOfWork, UserManager<User> userManager)
    {
        _unitOfWork = unitOfWork;
        _userManager = userManager;
    }

    public async Task<BrandDashboardRes> GetBrandDashboardAsync(string userId)
    {
        var brand = await _unitOfWork.Repository<Brand>()
            .FirstOrDefaultAsync(b => b.UserId == userId);

        if (brand == null)
            return new BrandDashboardRes();

        var brandId = brand.Id;

        var productCount = await _unitOfWork.Repository<Product>()
            .CountAsync(new BrandProductsCountSpec(brandId));

        var orderProductQuery = _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
            .Where(op => op.BrandId == brandId);

        var orderIds = await orderProductQuery
            .Select(op => op.OrderId)
            .Distinct()
            .ToListAsync();

        var totalOrders = orderIds.Count;

        var deliveredOrderIds = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => orderIds.Contains(o.Id) && o.OrderStatus == OrderStatus.Delivered)
            .Select(o => o.Id)
            .ToListAsync();

        var totalRevenue = await orderProductQuery
            .Where(op => deliveredOrderIds.Contains(op.OrderId))
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var now = DateTime.UtcNow;
        var startOfMonth = new DateTime(now.Year, now.Month, 1);

        var monthlyRevenue = await orderProductQuery
            .Where(op => deliveredOrderIds.Contains(op.OrderId)
                && op.Order.CreatedAt >= startOfMonth)
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var reels = await _unitOfWork.Repository<Reel>()
            .GetAllWithSpecAsync(new BrandReelCountSpec(brandId));

        var posts = await _unitOfWork.Repository<CommunityPost>()
            .GetAllWithSpecAsync(new BrandPostCountSpec(brandId));

        var reelStats = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .Select(r => new
            {
                r.Id,
                r.Title,
                r.ThumbnailUrl,
                Views = r.UserReelViews.Count,
                Likes = r.UserReelLikes.Count
            })
            .ToListAsync();

        var totalReelViews = reelStats.Sum(r => r.Views);
        var totalReelLikes = reelStats.Sum(r => r.Likes);

        var topViewedReels = reelStats
            .OrderByDescending(r => r.Views)
            .Take(5)
            .Select(r => new TopReelDto
            {
                ReelId = r.Id,
                Title = r.Title,
                ThumbnailUrl = r.ThumbnailUrl,
                Views = r.Views,
                Likes = r.Likes
            })
            .ToList();

        var topLikedReels = reelStats
            .OrderByDescending(r => r.Likes)
            .Take(5)
            .Select(r => new TopReelDto
            {
                ReelId = r.Id,
                Title = r.Title,
                ThumbnailUrl = r.ThumbnailUrl,
                Views = r.Views,
                Likes = r.Likes
            })
            .ToList();

        var recentOrderProducts = await orderProductQuery
            .Include(op => op.Order)
            .OrderByDescending(op => op.Order.CreatedAt)
            .Take(20)
            .ToListAsync();

        var recentOrders = recentOrderProducts
            .GroupBy(op => op.OrderId)
            .Select(g => new RecentOrderDto
            {
                OrderId = g.Key,
                CreatedAt = g.First().Order.CreatedAt,
                TotalAmount = g.First().Order.TotalAmount,
                Status = g.First().Order.OrderStatus,
                ItemCount = g.Sum(op => op.Quantity)
            })
            .OrderByDescending(o => o.CreatedAt)
            .Take(5)
            .ToList();

        var twelveMonthsAgo = now.AddMonths(-12);

        var revenueTrend = await orderProductQuery
            .Where(op => deliveredOrderIds.Contains(op.OrderId)
                && op.Order.CreatedAt >= twelveMonthsAgo)
            .GroupBy(op => new { op.Order.CreatedAt.Year, op.Order.CreatedAt.Month })
            .Select(g => new MonthlyRevenueDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Revenue = g.Sum(op => op.FinalPrice * op.Quantity)
            })
            .OrderBy(r => r.Year).ThenBy(r => r.Month)
            .ToListAsync();

        var topProducts = await orderProductQuery
            .GroupBy(op => new { op.ProductId, op.ProductName })
            .Select(g => new TopProductDto
            {
                ProductId = g.Key.ProductId ?? 0,
                Name = g.Key.ProductName ?? "",
                TotalSold = g.Sum(op => op.Quantity),
                Revenue = g.Sum(op => op.FinalPrice * op.Quantity)
            })
            .OrderByDescending(p => p.TotalSold)
            .Take(5)
            .ToListAsync();

        if (topProducts.Count > 0)
        {
            var productIds = topProducts.Select(p => p.ProductId).ToList();
            var images = await _unitOfWork.Repository<ProductImage>().GetAllQueryable()
                .Where(pi => productIds.Contains(pi.ProductId))
                .GroupBy(pi => pi.ProductId)
                .Select(g => new { ProductId = g.Key, Url = g.Min(pi => pi.Url) })
                .ToListAsync();

            foreach (var tp in topProducts)
            {
                tp.ImageUrl = images.FirstOrDefault(i => i.ProductId == tp.ProductId)?.Url;
            }
        }

        // Active Customers
        var activeCustomers = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => deliveredOrderIds.Contains(o.Id))
            .Select(o => o.UserId)
            .Distinct()
            .CountAsync();

        // Previous month calculations
        var startOfPreviousMonth = startOfMonth.AddMonths(-1);

        var previousMonthRevenue = await orderProductQuery
            .Where(op => deliveredOrderIds.Contains(op.OrderId)
                && op.Order.CreatedAt >= startOfPreviousMonth
                && op.Order.CreatedAt < startOfMonth)
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var revenueGrowth = previousMonthRevenue > 0
            ? Math.Round((double)((monthlyRevenue - previousMonthRevenue) / previousMonthRevenue * 100), 1)
            : 0;

        var currentMonthOrders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => deliveredOrderIds.Contains(o.Id) && o.CreatedAt >= startOfMonth)
            .CountAsync();

        var previousMonthOrders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => deliveredOrderIds.Contains(o.Id)
                && o.CreatedAt >= startOfPreviousMonth
                && o.CreatedAt < startOfMonth)
            .CountAsync();

        var ordersGrowth = previousMonthOrders > 0
            ? Math.Round((double)(currentMonthOrders - previousMonthOrders) / previousMonthOrders * 100, 1)
            : 0;

        // Customers growth
        var currentMonthCustomers = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => deliveredOrderIds.Contains(o.Id) && o.CreatedAt >= startOfMonth)
            .Select(o => o.UserId)
            .Distinct()
            .CountAsync();

        var previousMonthCustomers = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => deliveredOrderIds.Contains(o.Id)
                && o.CreatedAt >= startOfPreviousMonth
                && o.CreatedAt < startOfMonth)
            .Select(o => o.UserId)
            .Distinct()
            .CountAsync();

        var customersGrowth = previousMonthCustomers > 0
            ? Math.Round((double)(currentMonthCustomers - previousMonthCustomers) / previousMonthCustomers * 100, 1)
            : 0;

        // Sales Growth (current year vs previous year from revenueTrend)
        var currentYearRevenue = revenueTrend
            .Where(r => r.Year == now.Year)
            .Sum(r => r.Revenue);

        var previousYearRevenue = revenueTrend
            .Where(r => r.Year == now.Year - 1)
            .Sum(r => r.Revenue);

        var salesGrowth = previousYearRevenue > 0
            ? Math.Round((double)((currentYearRevenue - previousYearRevenue) / previousYearRevenue * 100), 1)
            : 0;

        // Order Status Overview (all orders for this brand, grouped by time window)
        var startOfWeek = now.Date.AddDays(-(int)now.DayOfWeek);
        var startOfYear = new DateTime(now.Year, 1, 1);

        var allBrandOrders = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => orderIds.Contains(o.Id))
            .Select(o => new { o.OrderStatus, o.CreatedAt })
            .ToListAsync();

        var thisWeekOrders = allBrandOrders.Where(o => o.CreatedAt >= startOfWeek).ToList();
        var thisMonthOrders = allBrandOrders.Where(o => o.CreatedAt >= startOfMonth).ToList();
        var thisYearOrders = allBrandOrders.Where(o => o.CreatedAt >= startOfYear).ToList();

        var orderStatusOverview = new OrderStatusOverviewDto
        {
            ThisWeek = new OrderStatusCounts
            {
                Pending = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Pending),
                Processing = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Processing),
                Preparing = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Preparing),
                Packed = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Packed),
                Shipped = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Shipped),
                Delivered = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Delivered),
                Cancelled = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.Cancelled),
                PendingCancellation = thisWeekOrders.Count(o => o.OrderStatus == OrderStatus.PendingCancellation)
            },
            ThisMonth = new OrderStatusCounts
            {
                Pending = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Pending),
                Processing = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Processing),
                Preparing = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Preparing),
                Packed = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Packed),
                Shipped = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Shipped),
                Delivered = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Delivered),
                Cancelled = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.Cancelled),
                PendingCancellation = thisMonthOrders.Count(o => o.OrderStatus == OrderStatus.PendingCancellation)
            },
            ThisYear = new OrderStatusCounts
            {
                Pending = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Pending),
                Processing = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Processing),
                Preparing = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Preparing),
                Packed = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Packed),
                Shipped = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Shipped),
                Delivered = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Delivered),
                Cancelled = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.Cancelled),
                PendingCancellation = thisYearOrders.Count(o => o.OrderStatus == OrderStatus.PendingCancellation)
            }
        };

        return new BrandDashboardRes
        {
            TotalProducts = productCount,
            TotalOrders = totalOrders,
            TotalRevenue = totalRevenue,
            MonthlyRevenue = monthlyRevenue,
            RevenueGrowthPercentage = revenueGrowth,
            OrdersGrowthPercentage = ordersGrowth,
            ActiveCustomers = activeCustomers,
            CustomersGrowthPercentage = customersGrowth,
            SalesGrowthPercentage = salesGrowth,
            ReelCounts = new ReelCountsDto
            {
                All = reels.Count,
                Published = reels.Count(r => r.Status == ReelStatus.Published),
                Draft = reels.Count(r => r.Status == ReelStatus.Draft)
            },
            PostCounts = new PostCountsDto
            {
                All = posts.Count,
                Published = posts.Count(p => p.Status == PostStatus.Published),
                Draft = posts.Count(p => p.Status == PostStatus.Draft)
            },
            RecentOrders = recentOrders,
            RevenueTrend = revenueTrend,
            TopProducts = topProducts,
            TotalReelViews = totalReelViews,
            TotalReelLikes = totalReelLikes,
            TopViewedReels = topViewedReels,
            TopLikedReels = topLikedReels,
            OrderStatusOverview = orderStatusOverview
        };
    }

    public async Task<AdminDashboardRes> GetAdminDashboardAsync(int? year = null)
    {
        var totalBrands = await _unitOfWork.Repository<Brand>().GetAllQueryable().CountAsync();

        var totalUsers = _userManager.Users.Count();

        var pendingCount = await _unitOfWork.Repository<Brand>()
            .CountAsync(new GetPendingBrandsSpec());

        var totalOrders = await _unitOfWork.Repository<Order>().GetAllQueryable().CountAsync();

        var totalProducts = await _unitOfWork.Repository<Product>().GetAllQueryable().CountAsync();

        var totalReels = await _unitOfWork.Repository<Reel>().GetAllQueryable().CountAsync();

        var now = DateTime.UtcNow;
        var twelveMonthsAgo = now.AddMonths(-12);

        var deliveredOrderProducts = _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
            .Where(op => op.Order.OrderStatus == OrderStatus.Delivered);

        var totalRevenue = await deliveredOrderProducts
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var brandSalesRevenue = totalRevenue;

        var reelStats = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Select(r => new
            {
                Views = r.UserReelViews.Count,
                Likes = r.UserReelLikes.Count,
                Comments = r.ReelComments.Count
            })
            .ToListAsync();

        var totalReelViews = reelStats.Sum(r => r.Views);
        var totalReelLikes = reelStats.Sum(r => r.Likes);
        var totalReelComments = reelStats.Sum(r => r.Comments);

        var engagementRate = totalReelViews > 0
            ? Math.Round((double)(totalReelLikes + totalReelComments) / totalReelViews * 100, 1)
            : 0;

        var activeBrands = await _unitOfWork.Repository<Brand>().GetAllQueryable()
            .CountAsync(b => b.Status == BrandStatus.APPROVED);

        var activeUsers = _userManager.Users.Count();

        // Build base queries with optional year filter
        IQueryable<Brand> brandQuery = _unitOfWork.Repository<Brand>().GetAllQueryable();
        IQueryable<User> userQuery = _userManager.Users;
        IQueryable<OrderProduct> orderProductQuery = deliveredOrderProducts;
        IQueryable<Order> orderQuery = _unitOfWork.Repository<Order>().GetAllQueryable();

        if (year.HasValue)
        {
            brandQuery = brandQuery.Where(b => b.CreatedAt.Year == year.Value);
            userQuery = userQuery.Where(u => u.CreatedAt.Year == year.Value);
            orderProductQuery = orderProductQuery.Where(op => op.Order.CreatedAt.Year == year.Value);
            orderQuery = orderQuery.Where(o => o.CreatedAt.Year == year.Value);
        }

        var brandGrowth = await brandQuery
            .Where(b => b.CreatedAt >= twelveMonthsAgo)
            .GroupBy(b => new { b.CreatedAt.Year, b.CreatedAt.Month })
            .Select(g => new MonthlyGrowthDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Count = g.Count()
            })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var userGrowth = await userQuery
            .Where(u => u.CreatedAt >= twelveMonthsAgo)
            .GroupBy(u => new { u.CreatedAt.Year, u.CreatedAt.Month })
            .Select(g => new MonthlyGrowthDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Count = g.Count()
            })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var revenueTrend = await orderProductQuery
            .Where(op => op.Order.CreatedAt >= twelveMonthsAgo)
            .GroupBy(op => new { op.Order.CreatedAt.Year, op.Order.CreatedAt.Month })
            .Select(g => new MonthlyRevenueDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Revenue = g.Sum(op => op.FinalPrice * op.Quantity)
            })
            .OrderBy(r => r.Year).ThenBy(r => r.Month)
            .ToListAsync();

        var monthlyOrdersTrend = await orderQuery
            .Where(o => o.CreatedAt >= twelveMonthsAgo)
            .GroupBy(o => new { o.CreatedAt.Year, o.CreatedAt.Month })
            .Select(g => new MonthlyGrowthDto
            {
                Year = g.Key.Year,
                Month = g.Key.Month,
                Count = g.Count()
            })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        // Growth percentages (computed from all-time data regardless of year filter)
        var startOfMonth = new DateTime(now.Year, now.Month, 1);
        var startOfPreviousMonth = startOfMonth.AddMonths(-1);

        var currentMonthRevenue = await deliveredOrderProducts
            .Where(op => op.Order.CreatedAt >= startOfMonth)
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var previousMonthRevenue = await deliveredOrderProducts
            .Where(op => op.Order.CreatedAt >= startOfPreviousMonth && op.Order.CreatedAt < startOfMonth)
            .SumAsync(op => op.FinalPrice * op.Quantity);

        var revenueGrowthPercentage = previousMonthRevenue > 0
            ? Math.Round((double)((currentMonthRevenue - previousMonthRevenue) / previousMonthRevenue * 100), 1)
            : 0;

        var currentMonthOrdersCount = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.CreatedAt >= startOfMonth)
            .CountAsync();

        var previousMonthOrdersCount = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => o.CreatedAt >= startOfPreviousMonth && o.CreatedAt < startOfMonth)
            .CountAsync();

        var ordersGrowthPercentage = previousMonthOrdersCount > 0
            ? Math.Round((double)(currentMonthOrdersCount - previousMonthOrdersCount) / previousMonthOrdersCount * 100, 1)
            : 0;

        var pendingBrands = await _unitOfWork.Repository<Brand>()
            .GetAllWithSpecAsync(new GetPendingBrandsSpec());

        var recentRequests = pendingBrands
            .OrderByDescending(b => b.CreatedAt)
            .Take(5)
            .Select(b => new BrandDetailsDto
            {
                Id = b.Id,
                DisplayName = b.DisplayName,
                Status = b.Status.ToString(),
                UserName = b.user != null ? b.user.DisplayName : null
            })
            .ToList();

        var topBrands = await _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
            .Where(op => op.Order.OrderStatus == OrderStatus.Delivered)
            .GroupBy(op => new { op.BrandId, BrandName = op.ProductName })
            .Select(g => new ReelsCommerceSystem.Application.DTOs.Response.Dashboard.TopBrandDto
            {
                BrandId = g.Key.BrandId,
                BrandName = g.Key.BrandName,
                TotalRevenue = g.Sum(op => op.FinalPrice * op.Quantity),
                TotalOrders = g.Select(op => op.OrderId).Distinct().Count()
            })
            .OrderByDescending(b => b.TotalRevenue)
            .Take(5)
            .ToListAsync();

        // Monthly engagement trend (reel views/likes/comments grouped by month)
        var monthlyViewsData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .SelectMany(r => r.UserReelViews)
            .Where(v => v.CreatedAt >= twelveMonthsAgo)
            .GroupBy(v => new { v.CreatedAt.Year, v.CreatedAt.Month })
            .Select(g => new { g.Key.Year, g.Key.Month, Views = g.Count() })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var monthlyLikesData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .SelectMany(r => r.UserReelLikes)
            .Where(l => l.CreatedAt >= twelveMonthsAgo)
            .GroupBy(l => new { l.CreatedAt.Year, l.CreatedAt.Month })
            .Select(g => new { g.Key.Year, g.Key.Month, Likes = g.Count() })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var monthlyCommentsData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .SelectMany(r => r.ReelComments)
            .Where(c => c.CreatedAt >= twelveMonthsAgo)
            .GroupBy(c => new { c.CreatedAt.Year, c.CreatedAt.Month })
            .Select(g => new { g.Key.Year, g.Key.Month, Comments = g.Count() })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var allMonths = monthlyViewsData
            .Select(g => new { g.Year, g.Month })
            .Union(monthlyLikesData.Select(g => new { g.Year, g.Month }))
            .Union(monthlyCommentsData.Select(g => new { g.Year, g.Month }))
            .Distinct()
            .OrderBy(m => m.Year).ThenBy(m => m.Month)
            .ToList();

        var monthlyEngagementTrend = allMonths.Select(m => new MonthlyEngagementDto
        {
            Year = m.Year,
            Month = m.Month,
            Views = monthlyViewsData.FirstOrDefault(v => v.Year == m.Year && v.Month == m.Month)?.Views ?? 0,
            Likes = monthlyLikesData.FirstOrDefault(l => l.Year == m.Year && l.Month == m.Month)?.Likes ?? 0,
            Comments = monthlyCommentsData.FirstOrDefault(c => c.Year == m.Year && c.Month == m.Month)?.Comments ?? 0,
            EngagementRate = (monthlyViewsData.FirstOrDefault(v => v.Year == m.Year && v.Month == m.Month)?.Views ?? 0) > 0
                ? Math.Round(
                    (double)(((monthlyLikesData.FirstOrDefault(l => l.Year == m.Year && l.Month == m.Month)?.Likes ?? 0)
                    + (monthlyCommentsData.FirstOrDefault(c => c.Year == m.Year && c.Month == m.Month)?.Comments ?? 0))
                    / (monthlyViewsData.FirstOrDefault(v => v.Year == m.Year && v.Month == m.Month)?.Views ?? 1) * 100), 1)
                : 0
        }).ToList();

        var deliveryRevenue = await _unitOfWork.Repository<ShippingSettlement>()
            .GetAllQueryable()
            .Where(s => s.ShippingCompanyId == 1)
            .SumAsync(s => s.Amount);

        return new AdminDashboardRes
        {
            TotalBrands = totalBrands,
            TotalUsers = totalUsers,
            PendingRequests = pendingCount,
            TotalOrders = totalOrders,
            TotalRevenue = totalRevenue,
            TotalProducts = totalProducts,
            TotalReels = totalReels,
            TotalReelViews = totalReelViews,
            EngagementRate = engagementRate,
            BrandSalesRevenue = brandSalesRevenue,
            DeliveryRevenue = deliveryRevenue,
            AdsRevenue = 0,
            ActiveBrands = activeBrands,
            ActiveUsers = activeUsers,
            RevenueGrowthPercentage = revenueGrowthPercentage,
            OrdersGrowthPercentage = ordersGrowthPercentage,
            BrandGrowth = brandGrowth,
            UserGrowth = userGrowth,
            RevenueTrend = revenueTrend,
            MonthlyOrdersTrend = monthlyOrdersTrend,
            RecentBrandRequests = recentRequests,
            TopBrands = topBrands,
            MonthlyEngagementTrend = monthlyEngagementTrend
        };
    }

    public async Task<BrandReelAnalyticsRes> GetBrandReelAnalyticsAsync(string userId)
    {
        var brand = await _unitOfWork.Repository<Brand>()
            .FirstOrDefaultAsync(b => b.UserId == userId);

        if (brand == null)
            return new BrandReelAnalyticsRes();

        var brandId = brand.Id;

        var allReels = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .Select(r => new
            {
                r.Id,
                r.Title,
                r.ThumbnailUrl,
                r.Status,
                Views = r.UserReelViews.Count,
                Likes = r.UserReelLikes.Count
            })
            .ToListAsync();

        var totalViews = allReels.Sum(r => r.Views);
        var totalLikes = allReels.Sum(r => r.Likes);

        var now = DateTime.UtcNow;
        var twelveMonthsAgo = now.AddMonths(-12);

        var viewsWithDates = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .Where(v => v.CreatedAt >= twelveMonthsAgo)
            .GroupBy(v => new { v.CreatedAt.Year, v.CreatedAt.Month })
            .Select(g => new { g.Key.Year, g.Key.Month, Count = g.Count() })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var likesWithDates = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelLikes)
            .Where(l => l.CreatedAt >= twelveMonthsAgo)
            .GroupBy(l => new { l.CreatedAt.Year, l.CreatedAt.Month })
            .Select(g => new { g.Key.Year, g.Key.Month, Count = g.Count() })
            .OrderBy(g => g.Year).ThenBy(g => g.Month)
            .ToListAsync();

        var monthlyViews = viewsWithDates
            .Select(g => new MonthlyReelStatDto
            {
                Month = new DateTime(g.Year, g.Month, 1).ToString("MMM"),
                Count = g.Count
            })
            .ToList();

        var monthlyLikes = likesWithDates
            .Select(g => new MonthlyReelStatDto
            {
                Month = new DateTime(g.Year, g.Month, 1).ToString("MMM"),
                Count = g.Count
            })
            .ToList();

        // Daily views/likes (last 7 days) for Weekly chart
        var sevenDaysAgo = now.Date.AddDays(-6);

        var dailyViewsData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .Where(v => v.CreatedAt.Date >= sevenDaysAgo)
            .GroupBy(v => v.CreatedAt.Date)
            .Select(g => new { Date = g.Key, Count = g.Count() })
            .OrderBy(g => g.Date)
            .ToListAsync();

        var dailyLikesData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelLikes)
            .Where(l => l.CreatedAt.Date >= sevenDaysAgo)
            .GroupBy(l => l.CreatedAt.Date)
            .Select(g => new { Date = g.Key, Count = g.Count() })
            .OrderBy(g => g.Date)
            .ToListAsync();

        var dailyViewStats = dailyViewsData
            .Select(g => new DailyReelStatDto
            {
                Date = g.Date.ToString("MMM dd"),
                Count = g.Count
            })
            .ToList();

        var dailyLikeStats = dailyLikesData
            .Select(g => new DailyReelStatDto
            {
                Date = g.Date.ToString("MMM dd"),
                Count = g.Count
            })
            .ToList();

        // Yearly views/likes for Yearly chart
        var yearlyViewsData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .GroupBy(v => v.CreatedAt.Year)
            .Select(g => new YearlyReelStatDto
            {
                Year = g.Key,
                Count = g.Count()
            })
            .OrderBy(g => g.Year)
            .ToListAsync();

        var yearlyLikesData = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelLikes)
            .GroupBy(l => l.CreatedAt.Year)
            .Select(g => new YearlyReelStatDto
            {
                Year = g.Key,
                Count = g.Count()
            })
            .OrderBy(g => g.Year)
            .ToListAsync();

        var currentMonthViews = viewsWithDates
            .Where(g => g.Year == now.Year && g.Month == now.Month)
            .Sum(g => g.Count);

        var lastMonthViews = viewsWithDates
            .Where(g => g.Year == now.AddMonths(-1).Year && g.Month == now.AddMonths(-1).Month)
            .Sum(g => g.Count);

        var currentMonthLikes = likesWithDates
            .Where(g => g.Year == now.Year && g.Month == now.Month)
            .Sum(g => g.Count);

        var lastMonthLikes = likesWithDates
            .Where(g => g.Year == now.AddMonths(-1).Year && g.Month == now.AddMonths(-1).Month)
            .Sum(g => g.Count);

        var viewsGrowth = lastMonthViews > 0
            ? Math.Round((double)(currentMonthViews - lastMonthViews) / lastMonthViews * 100, 1)
            : 0;

        var likesGrowth = lastMonthLikes > 0
            ? Math.Round((double)(currentMonthLikes - lastMonthLikes) / lastMonthLikes * 100, 1)
            : 0;

        var topViewedReels = allReels
            .OrderByDescending(r => r.Views)
            .Take(5)
            .Select(r => new TopReelDto
            {
                ReelId = r.Id,
                Title = r.Title,
                ThumbnailUrl = r.ThumbnailUrl,
                Views = r.Views,
                Likes = r.Likes
            })
            .ToList();

        var topLikedReels = allReels
            .OrderByDescending(r => r.Likes)
            .Take(5)
            .Select(r => new TopReelDto
            {
                ReelId = r.Id,
                Title = r.Title,
                ThumbnailUrl = r.ThumbnailUrl,
                Views = r.Views,
                Likes = r.Likes
            })
            .ToList();

        // Audience Stats
        var followersCount = await _unitOfWork.Repository<UserBrandFollow>()
            .GetAllQueryable()
            .CountAsync(f => f.BrandId == brandId);

        var viewerUserIds = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .Select(v => v.UserId)
            .Distinct()
            .ToListAsync();

        var followerUserIds = await _unitOfWork.Repository<UserBrandFollow>()
            .GetAllQueryable()
            .Where(f => f.BrandId == brandId)
            .Select(f => f.UserId)
            .ToListAsync();

        var nonFollowersCount = viewerUserIds.Except(followerUserIds).Count();

        var thirtyDaysAgo = now.AddDays(-30);
        var newUsersCount = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .GroupBy(v => v.UserId)
            .Select(g => new { UserId = g.Key, FirstView = g.Min(v => v.CreatedAt) })
            .CountAsync(u => u.FirstView >= thirtyDaysAgo);

        var lastMonthFollowerCount = 0; // simplified: no historical tracking in UserBrandFollow
        var followersGrowth = followersCount > 0 ? 0.0 : 0;
        var nonFollowersGrowth = nonFollowersCount > 0 ? 0.0 : 0;
        var newUsersGrowth = newUsersCount > 0 ? 0.0 : 0;

        // Most Viewed Products
        var topProducts = await _unitOfWork.Repository<Product>().GetAllQueryable()
            .Where(p => p.BrandId == brandId)
            .Select(p => new
            {
                p.Id,
                p.Name,
                Views = p.UserProductViews.Count,
                ImageUrl = p.Images!.Select(i => i.Url).FirstOrDefault()
            })
            .OrderByDescending(p => p.Views)
            .Take(5)
            .ToListAsync();

        var mostViewedProducts = topProducts
            .Select(p => new MostViewedProductDto
            {
                ProductId = p.Id,
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                Views = p.Views
            })
            .ToList();

        // Product Views Count (total)
        var productViewsCount = await _unitOfWork.Repository<Product>().GetAllQueryable()
            .Where(p => p.BrandId == brandId)
            .SelectMany(p => p.UserProductViews)
            .CountAsync();

        // Daily Engagement (last 12 months, grouped by day of week)
        var dailyViews = new int[7];
        var dailyLikes = new int[7];
        var dailyComments = new int[7];

        var viewDays = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelViews)
            .Where(v => v.CreatedAt >= twelveMonthsAgo)
            .Select(v => (int)v.CreatedAt.DayOfWeek)
            .ToListAsync();

        var likeDays = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.UserReelLikes)
            .Where(l => l.CreatedAt >= twelveMonthsAgo)
            .Select(l => (int)l.CreatedAt.DayOfWeek)
            .ToListAsync();

        var commentDays = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.ReelComments)
            .Where(c => c.CreatedAt >= twelveMonthsAgo)
            .Select(c => (int)c.CreatedAt.DayOfWeek)
            .ToListAsync();

        foreach (var d in viewDays) if (d >= 0 && d < 7) dailyViews[d]++;
        foreach (var d in likeDays) if (d >= 0 && d < 7) dailyLikes[d]++;
        foreach (var d in commentDays) if (d >= 0 && d < 7) dailyComments[d]++;

        // Engagement Rate
        var totalComments = await _unitOfWork.Repository<Reel>().GetAllQueryable()
            .Where(r => r.BrandId == brandId)
            .SelectMany(r => r.ReelComments)
            .CountAsync();

        var engagementRate = totalViews > 0
            ? Math.Round((double)(totalLikes + totalComments) / totalViews * 100, 1)
            : 0;

        return new BrandReelAnalyticsRes
        {
            TotalViews = totalViews,
            TotalLikes = totalLikes,
            ViewsGrowthPercentage = viewsGrowth,
            LikesGrowthPercentage = likesGrowth,
            ReelCounts = new ReelCountsDto
            {
                All = allReels.Count,
                Published = allReels.Count(r => r.Status == ReelStatus.Published),
                Draft = allReels.Count(r => r.Status == ReelStatus.Draft)
            },
            MonthlyViews = monthlyViews,
            MonthlyLikes = monthlyLikes,
            DailyViews = dailyViewStats,
            DailyLikes = dailyLikeStats,
            YearlyViews = yearlyViewsData,
            YearlyLikes = yearlyLikesData,
            TopViewedReels = topViewedReels,
            TopLikedReels = topLikedReels,
            AudienceStats = new AudienceStatsDto
            {
                FollowersCount = followersCount,
                NonFollowersCount = nonFollowersCount,
                NewUsersCount = newUsersCount,
                FollowersGrowth = followersGrowth,
                NonFollowersGrowth = nonFollowersGrowth,
                NewUsersGrowth = newUsersGrowth
            },
            MostViewedProducts = mostViewedProducts,
            ProductViewsCount = productViewsCount,
            DailyEngagement = new DailyEngagementDto
            {
                DailyViews = dailyViews.ToList(),
                DailyLikes = dailyLikes.ToList(),
                DailyComments = dailyComments.ToList(),
                TotalViews = totalViews,
                TotalLikes = totalLikes,
                TotalComments = totalComments
            },
            EngagementRate = engagementRate
        };
    }

    public async Task<OrdersByRegionRes> GetOrdersByRegionAsync(string userId)
    {
        var brand = await _unitOfWork.Repository<Brand>()
            .FirstOrDefaultAsync(b => b.UserId == userId);

        if (brand == null)
            return new OrdersByRegionRes();

        var orderProducts = _unitOfWork.Repository<OrderProduct>().GetAllQueryable()
            .Where(op => op.BrandId == brand.Id);

        var orderIds = await orderProducts
            .Select(op => op.OrderId)
            .Distinct()
            .ToListAsync();

        var regionData = await _unitOfWork.Repository<Order>().GetAllQueryable()
            .Where(o => orderIds.Contains(o.Id))
            .GroupBy(o => o.ShippingCity ?? "Unknown")
            .Select(g => new RegionOrderCount
            {
                City = g.Key,
                OrderCount = g.Count()
            })
            .OrderByDescending(r => r.OrderCount)
            .ToListAsync();

        return new OrdersByRegionRes
        {
            TotalOrders = orderIds.Count,
            Regions = regionData
        };
    }
}
