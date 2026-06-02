using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Application.DTOs.Response.PagedResponse;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Utilities;
using System.Globalization;


namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class ReelManagementService(IUnitOfWork _unitOfWork, 
        UserManager<User> _userManager,
        IRecommendationService _recommendationService,
        ICloudinaryService _cloudinaryService) : IReelManagementService
    {
        public async Task<CreateReelRes> CreateReelAsync(CreateReelReq req, string userId)
        {
            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            var user = await _userManager.FindByIdAsync(userId);
            if (user is null || brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");


            if (string.IsNullOrWhiteSpace(req.Title))
                throw new BadRequestException("Title is required");

            if (req.Video is null)
                throw new BadRequestException("Video is required");

            var productIds = new List<int>();
            if (req.ProductIds is not null)
            {
                productIds = req.ProductIds
                              .Split(',', StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();
                productIds = productIds.Distinct().ToList();

                if (productIds.Count > 5)
                    throw new BadRequestException("Maximum 5 products allowed");

                var productSpec = new GetProductsByIdsForBrandSpec(productIds, brand.Id);
                var products = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(productSpec);

                if (products.Count != productIds.Count)
                    throw new BadRequestException("Some products are invalid or not belong to this brand");

            }
            

            var videoUrl = await _cloudinaryService.UploadVideoAsync(req.Video);

            ReelStatus reelStatus = ReelStatus.Draft;

            if (req.Status is not null && (req.Status.ToLower() == ReelStatus.Published.ToString().ToLower()))
                reelStatus = ReelStatus.Published;


            var reel = new Reel
            {
                Title = req.Title,
                VideoUrl = videoUrl,
                ThumbnailUrl=FileHelper.GenerateThumbnailUrl(videoUrl),
                Status = reelStatus,
                BrandId = brand.Id,


                ProductReels = productIds.Select(pid => new ProductReels
                {
                    ProductId = pid
                }).ToList()
            };

            await _unitOfWork.Repository<Reel>().AddAsync(reel);
            reel.Brand = brand;
            await _unitOfWork.SaveChangesAsync();

            _ = _recommendationService.ProcessReelAsync(reel);

            return new CreateReelRes
            {
                Id = reel.Id,
                Thumbnail = reel.ThumbnailUrl
            };
        }

        public async Task<GetBrandReelsRes> GetBrandReelsAsync(GetBrandReelsReq req,string userId)
        {
            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);
            if (brand is null)
                throw new NotFoundException("Brand Not Found");
            req.BrandId = brand.Id;

            var user = await _userManager.FindByIdAsync(userId);
            if (user is null || brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");

            
            var spec = new GetBrandReelsSpec(req);
            var reels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

            var countSpec = new GetBrandReelsSpec(new GetBrandReelsReq
            {
                BrandId = req.BrandId,
                Status = req.Status,
                Search = req.Search
            });

            var totalItems = await _unitOfWork.Repository<Reel>().CountAsync(countSpec);

            var allReelsSpec = new BrandReelsCountSpec(req.BrandId);
            var allReels = await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(allReelsSpec);

            var counts = new ReelsCountsRes
            {
                All = allReels.Count,
                Published = allReels.Count(r => r.Status == ReelStatus.Published),
                Draft = allReels.Count(r => r.Status == ReelStatus.Draft)
            };

            var data = reels.Select(r => new ReelInBrandReelsRes
            {
                Id = r.Id,
                OwnerName = r.Brand.user.DisplayName,
                Title = r.Title,
                VideoUrl = r.VideoUrl,
                Status = r.Status.ToString().ToLower(),
                LikesCount = r.NumOfLikes,
                CommentsCount = r.ReelComments.Count,
                ProductsCount = r.ProductReels.Count,
                Products = r.ProductReels.Select(p => new ProductInReelRes{
                    Id = p.Product.Id,
                    Name=p.Product.Name,
                    Description=p.Product.Description,
                    ArDescription = p.Product.ArDescription,
                    Rating = p.Product.Rating,
                    StockStatus = p.Product.Status.ToString().ToLower(),
                    Price = p.Product.Price
                }).ToList(),
                CreatedAt = r.CreatedAt,
                Thumbnail = r.ThumbnailUrl ?? FileHelper.GenerateThumbnailUrl(r.VideoUrl)
            }).ToList();

            return new GetBrandReelsRes
            {
                Data = data,
                Pagination = new PaginationRes
                {
                    Page = req.PageIndex,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)req.PageSize),
                    TotalItems = totalItems
                },
                Counts = counts
            };

        }

        public async Task<GetProductsForBrandRes> GetProductsForBrandAsync(GetProductsForBrandReq req, string userId)
        {

            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            var brandId = brand.Id;

            var user = await _userManager.FindByIdAsync(userId);
            if (user is null || brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");


            var spec = new GetProductsForBrandSpec(brandId,req);
            var products = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(spec);

            if (!string.IsNullOrEmpty(req.StockStatus) && req.StockStatus.ToLower() != "all")
            {
                if (req.StockStatus.ToLower() == "instock")
                {
                    products = products
                        .Where(p => p.Quantity > 0)
                        .ToList();
                }
                else if (req.StockStatus.ToLower() == "outofstock")
                {
                    products = products
                        .Where(p => p.Quantity <= 0)
                        .ToList();
                }
            }

            var countSpec = new GetProductsForBrandSpec(brandId,new GetProductsForBrandReq
            {
                Search = req.Search
            });

            var totalItems = await _unitOfWork.Repository<Product>().CountAsync(countSpec);

            var data = products.Select(p => new ProductForBrandRes
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                ArDescription = p.ArDescription,
                Rating = p.Rating,
                StockStatus = p.Status.ToString().ToLower(),
                Price = p.Price,
                IsSelected = req.SelectedProductIds != null &&
                             req.SelectedProductIds.Contains(p.Id)

            }).ToList();

            return new GetProductsForBrandRes
            {
                Data = data,
                Pagination = new PaginationRes
                {
                    Page = req.PageIndex,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)req.PageSize),
                    TotalItems = totalItems
                }
            };


        }

        public async Task<EditReelRes> EditReelAsync(EditReelReq req, string userId)
        {
            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            
            var reelSpec = new GetReelwithProductsSpec(req.ReelId);
            var reel = await _unitOfWork.Repository<Reel>().GetWithSpecAsync(reelSpec);

            if (reel is null || reel.BrandId != brand.Id)
                throw new NotFoundException("Reel Not Found");

            if (reel.Brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");

           

            if (!string.IsNullOrWhiteSpace(req.Title))
            {
                if (req.Title == reel.Title)
                    throw new BadRequestException("New title must be different from current title");
                reel.Title = req.Title;
            }
            if (!string.IsNullOrWhiteSpace(req.Status))
            {
                ReelStatus reelStatus = Enum.Parse<ReelStatus>(req.Status, true);
                reel.Status = reelStatus;
            }
            if (req.ClearProducts)
            {
                await _unitOfWork.Repository<ProductReels>().DeleteRangeAsync(reel.ProductReels);

            }


            if (req.Video is not null)
            {
                var videoUrl = await _cloudinaryService.UploadVideoAsync(req.Video);

                reel.VideoUrl = videoUrl;
                reel.ThumbnailUrl = FileHelper.GenerateThumbnailUrl(videoUrl);
            }

            // Products
            if (req.ProductIds is not null && !req.ClearProducts)
            {
                var productIds = req.ProductIds
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                productIds = productIds.Distinct().ToList();

                if (productIds.Count > 5)
                    throw new BadRequestException("Maximum 5 products allowed");

                var productSpec = new GetProductsByIdsForBrandSpec(productIds, brand.Id);
                var products = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(productSpec);

                if (products.Count != productIds.Count)
                    throw new BadRequestException("Some products are invalid or do not belong to this brand");

                await _unitOfWork.Repository<ProductReels>().DeleteRangeAsync(reel.ProductReels);

                reel.ProductReels = productIds.Select(id => new ProductReels
                {
                    ProductId = id,
                    ReelId = reel.Id
                }).ToList();

            }

            bool hasChanges =
                !string.IsNullOrWhiteSpace(req.Title) ||
                req.Video is not null ||
                !string.IsNullOrWhiteSpace(req.Status) ||
                !string.IsNullOrWhiteSpace(req.ProductIds) ||
                req.ClearProducts == true;

            if (!hasChanges)
                throw new BadRequestException("No changes detected");

            reel.UpdatedAt = DateTime.UtcNow;
            _unitOfWork.Repository<Reel>().Update(reel);

            await _unitOfWork.SaveChangesAsync();

            _ = _recommendationService.ProcessReelAsync(reel);

            return new EditReelRes
            {
                Id = reel.Id,
                Thumbnail = reel.ThumbnailUrl!
            };
        }

        public async Task<GetReelForManagementRes> GetReelAsync(int reelId, string userId)
        {
            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            var reelspec = new GetReelForManagementSpec(reelId);
            var reel = await _unitOfWork.Repository<Reel>().GetWithSpecAsync(reelspec);
            if (reel is null)
                throw new NotFoundException("reel not found");

            if (reel.Brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");


            var result = new GetReelForManagementRes
            {
                Title = reel.Title,
                Status = reel.Status.ToString().ToLower(),
                ThumbnailUrl = reel.ThumbnailUrl!,
                VideoUrl = reel.VideoUrl,
                LikesCount = reel.UserReelLikes.Count,
                CommentsCount = reel.ReelComments.Count,
                ProductsCount = reel.ProductReels.Count,
                Brand = new BrandForGetReelForManagementRes
                {
                    BrandId = reel.BrandId,
                    BrandName = reel.Brand.DisplayName,
                    LogoUrl = reel.Brand.LogoUrl
                },
                Products = reel.ProductReels.Select(p => new ProductForGetReelForManagementRes
                {
                    ProductId = p.ProductId,
                    Name = p.Product.Name,
                    Price = p.Product.Price,
                    Rating = p.Product.Rating,
                    ImagesUrl = p.Product.Images!.Select(img => img.Url).ToList()??new List<string>(),
                }).ToList(),
                Comments = reel.ReelComments.Select(c => new CommentForGetReelForManagementRes
                {
                    Id = c.Id,
                    UserName = c.User.DisplayName,
                    UserImage = c.User.ImageURL,
                    Comment = c.Content,
                    CreatedAt = c.CreatedAt,
                    LikesCount = c.Loves.Count

                }).ToList()
            };

            return result;


        }

        public async Task<GetReelAnalyticsRes> GetReelAnalyticsAsync(int reelId,int year, string userId)
        {
            var brandSpec = new GetBrandByUserId(userId);

            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            var reelSpec = new GetReelAnalyticsSpec(reelId);

            var reel = await _unitOfWork.Repository<Reel>().GetWithSpecAsync(reelSpec);

            if (reel is null || reel.BrandId != brand.Id)
                throw new NotFoundException("Reel Not Found");

            var now = DateTime.UtcNow;

            var lastMonthDate = now.AddMonths(-1);

            // Current month views
            var currentMonthViews = reel.UserReelViews.Count(v =>
                v.CreatedAt.Month == now.Month &&
                v.CreatedAt.Year == now.Year);

            // Last month views
            var lastMonthViews = reel.UserReelViews.Count(v =>
                v.CreatedAt.Month == lastMonthDate.Month &&
                v.CreatedAt.Year == lastMonthDate.Year);

            // Growth percentage
            decimal growthPercentage = 0;

            var baseViews =currentMonthViews+lastMonthViews;

            if (baseViews > 0)
            {
                decimal currentPercentage =
                    ((decimal)currentMonthViews / baseViews) * 100;

                decimal lastPercentage =
                    ((decimal)lastMonthViews / baseViews) * 100;

                growthPercentage =
                    currentPercentage - lastPercentage;
            }

            growthPercentage = Math.Round(growthPercentage, 0);

            // Monthly chart
            var monthlyViews = reel.UserReelViews
                .Where(v => v.CreatedAt.Year == year)
                .GroupBy(v => v.CreatedAt.Month)
                .Select(g => new MonthlyViewsRes
                {
                    Month = CultureInfo.CurrentCulture
                        .DateTimeFormat
                        .GetAbbreviatedMonthName(g.Key),

                    Views = g.Count()
                })
                .OrderBy(m => DateTime.ParseExact(
                    m.Month,
                    "MMM",
                    CultureInfo.CurrentCulture).Month)
                .ToList();

            // Years dropdown
            var years = reel.UserReelViews
                .Select(v => v.CreatedAt.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();

            return new GetReelAnalyticsRes
            {
                GrowthPercentage = growthPercentage,

                CurrentMonthViews = currentMonthViews,

                LastMonthViews = lastMonthViews,

                Years = years,

                MonthlyViews = monthlyViews
            };
        }

        public async Task<bool> DeleteReelAsync(int reelId, string userId)
        {
           var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            var reel = await _unitOfWork.Repository<Reel>()
                .GetWithSpecAsync(new GetReelwithProductsSpec(reelId));

            if (reel is null)
                throw new NotFoundException("Reel Not Found");


            if (reel.Brand.UserId != userId)
                throw new BadRequestException("You don't have permission");


            _unitOfWork.Repository<Reel>().Delete(reel);
            await _unitOfWork.SaveChangesAsync();

            _ = _recommendationService.DeleteReelAsync(reelId);

            return true;
        }
    }
}
