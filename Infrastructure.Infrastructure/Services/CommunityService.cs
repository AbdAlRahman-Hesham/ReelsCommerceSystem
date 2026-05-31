using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Request.ReelManagement;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using ReelsCommerceSystem.Application.DTOs.Response.PagedResponse;
using ReelsCommerceSystem.Application.DTOs.Response.ReelManagement;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Community;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelManagementSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class CommunityService(IUnitOfWork _unitOfWork,
        UserManager<User> _userManager,
        ICloudinaryService _cloudinaryService) : ICommunityService
    {
        public async Task<CreatePostRes> CreatePostAsync(CreatePostReq req, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
                throw new BadRequestException("user not found");

            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new NotFoundException("Brand Not Found");

            if (brand.UserId != userId)
                throw new BadRequestException("You Don't Have This Permission");

            if (string.IsNullOrWhiteSpace(req.Title))
                throw new BadRequestException("Title is required");

            if (string.IsNullOrWhiteSpace(req.Content))
                throw new BadRequestException("Content is required");

            if (req.CoverImage is null)
                throw new BadRequestException("Cover Image is required");

            var coverImageUrl = await _cloudinaryService.UploadImageAsync(req.CoverImage);

            if (string.IsNullOrWhiteSpace(req.Status))
                req.Status = PostStatus.Draft.ToString().ToLower();

            var status = Enum.Parse<PostStatus>(req.Status, true);

            var slug = await GenerateUniqueSlugAsync(req.Title);

            var post = new CommunityPost
            {
                Title = req.Title,
                Slug = slug,
                Content = req.Content,
                CoverImageUrl = coverImageUrl,
                Status = status,
                CommentsEnabled = req.CommentsEnabled,
                BrandId = brand.Id
            };

            await _unitOfWork.Repository<CommunityPost>().AddAsync(post);
            await _unitOfWork.SaveChangesAsync();

            return new CreatePostRes
            {
                PostId = post.Id,
            };

        }
        public async Task<GetCommunityPostsRes> GetPostsAsync(GetCommunityPostsReq req, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
                throw new NotFoundException("user not found");

            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new BadRequestException("this service for brand owners only");

            var spec = new GetCommunityPostsSpec(req,brand.Id);
            var posts = await _unitOfWork.Repository<CommunityPost>()
                .GetAllWithSpecAsync(spec);

            var visiblePostsSpec = new communityPostsCountSpec(brand.Id);

            var visiblePosts = await _unitOfWork
                .Repository<CommunityPost>()
                .GetAllWithSpecAsync(visiblePostsSpec);

            var counts = new CommunityPostsCountsRes
            {
                All = visiblePosts.Count,

                Published = visiblePosts.Count(p =>
                    p.Status == PostStatus.Published),

                Draft = visiblePosts.Count(p =>
                    p.Status == PostStatus.Draft &&
                    p.BrandId == brand.Id)
            };

            var data = posts.Select(p => new PostInCommunityPostsRes
            {
                PostId = p.Id,
                Title = p.Title,
                Slug = p.Slug,
                CoverImageUrl = p.CoverImageUrl,
                Status = p.Status.ToString().ToLower(),
                CreatedAt = p.CreatedAt,
                BrandName = p.Brand.DisplayName,
                BrandOwnerName = p.Brand.user.DisplayName,
                BrandLogoUrl = p.Brand.LogoUrl

            }).ToList();

            var totalItems = await _unitOfWork.Repository<CommunityPost>()
                .CountAsync(spec);


            return new GetCommunityPostsRes
            {
                Data = data,
                Pagination =
                {
                    Page = req.PageIndex,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)req.PageSize),
                    TotalItems = totalItems
                },
                Counts = counts
            };

        }
        public async Task<GetPostRes> GetPostAsync(int postId, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
                throw new NotFoundException("user not found");

            var brandSpec = new GetBrandByUserId(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new BadRequestException("this service for brand owners only");

            var postSpec = new GetPostByIdSpec(postId);
            var post = await _unitOfWork.Repository<CommunityPost>().GetWithSpecAsync(postSpec);

            if (post is null)
                throw new NotFoundException("post not found");

            var IsDraft = post.Status == PostStatus.Draft;

            if (IsDraft && post.Brand.Id != brand.Id)
                throw new UnauthorizedException();

            var existingLike = await _unitOfWork.Repository<PostLike>()
                .FirstOrDefaultAsync(l => l.BrandId == brand.Id && l.PostId == post.Id);

            var isLiked = existingLike is not null;

            var result = new GetPostRes
            {
                Title = post.Title,
                Slug = post.Slug,
                Content = post.Content,
                CoverImageUrl = post.CoverImageUrl,
                Status = post.Status.ToString().ToLower(),
                CommentsEnabled = post.CommentsEnabled,
                BrandName = post.Brand.DisplayName,
                BrandOwnerName = post.Brand.user.DisplayName,
                CommentsCount = post.Comments.Count,
                LikesCount = post.Likes.Count,
                IsLiked=isLiked,
                CreatedAt = post.CreatedAt
            };

            return result;

        }
        public async Task<EditPostRes> EditPostAsync(EditPostReq req,string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
                throw new NotFoundException("user not found");

            var brandSpec = new GetBrandByUserId(userId);

            var brand = await _unitOfWork
                .Repository<Brand>()
                .GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new BadRequestException(
                    "this service for brand owners only");

            var postSpec = new GetPostByIdSpec(req.PostId);

            var post = await _unitOfWork
                .Repository<CommunityPost>()
                .GetWithSpecAsync(postSpec);

            if (post is null)
                throw new NotFoundException("post not found");

            if (post.BrandId != brand.Id)
                throw new UnauthorizedException();


            if (!string.IsNullOrWhiteSpace(req.Title) && post.Title.Trim() != req.Title.Trim()) 
            {
                post.Title = req.Title;
                post.Slug = await GenerateUniqueSlugAsync(req.Title);
            }

            if (!string.IsNullOrWhiteSpace(req.Content) && post.Content.Trim() != req.Content.Trim())
                post.Content = req.Content;

            if(req.CoverImage is not null)
            {
                var coverImageUrl =await _cloudinaryService.UploadImageAsync(req.CoverImage);
                post.CoverImageUrl = coverImageUrl;
            }

            if(req.CommentsEnabled.HasValue)
                post.CommentsEnabled = req.CommentsEnabled.Value;

            if (!string.IsNullOrWhiteSpace(req.Status))
                post.Status = Enum.Parse<PostStatus>(req.Status, true);

            if (req.Title is null &&
                req.Content is null &&
                req.Status is null &&
                req.CoverImage is null &&
                !req.CommentsEnabled.HasValue)
                throw new BadRequestException("No Changes Detected");

            post.UpdatedAt = DateTime.Now;
            _unitOfWork.Repository<CommunityPost>().Update(post);
            await _unitOfWork.SaveChangesAsync();

            return new EditPostRes
            {
                PostId = post.Id
            };
        }
        public async Task<bool> DeletePostAsync(int postId, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
                throw new NotFoundException("user not found");

            var brandSpec = new GetBrandByUserId(userId);

            var brand = await _unitOfWork
                .Repository<Brand>()
                .GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new BadRequestException(
                    "this service for brand owners only");

            var post = await _unitOfWork
                .Repository<CommunityPost>()
                .GetByIdAsync(postId);

            if (post is null)
                throw new NotFoundException("post not found");

            if (post.BrandId != brand.Id)
                throw new UnauthorizedException();

            _unitOfWork.Repository<CommunityPost>().Delete(post);
            await _unitOfWork.SaveChangesAsync();

            return true;

        }
        public async Task<TogglePostLikeRes> TogglePostLikeAsync(int postId,string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
                throw new NotFoundException("user not found");

            var brandSpec = new GetBrandByUserId(userId);

            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(brandSpec);

            if (brand is null)
                throw new BadRequestException("this service for brand owners only");

            var post = await _unitOfWork.Repository<CommunityPost>()
                .GetByIdAsync(postId);

            if (post is null)
                throw new NotFoundException("post not found");

            var spec = new Specification<PostLike>(
                x => x.BrandId == brand.Id &&
                     x.PostId == postId);

            var existingLike = await _unitOfWork.Repository<PostLike>()
                .GetWithSpecAsync(spec);

            bool isLiked;

            if (existingLike is null)
            {
                await _unitOfWork.Repository<PostLike>()
                    .AddAsync(new PostLike
                    {
                        BrandId = brand.Id,
                        PostId = postId
                    });

                isLiked = true;
            }
            else
            {
                _unitOfWork.Repository<PostLike>()
                    .Delete(existingLike);

                isLiked = false;
            }

            await _unitOfWork.SaveChangesAsync();

            var likesCount = await _unitOfWork.Repository<PostLike>()
                .CountAsync(new Specification<PostLike>(criteria:
                l => l.PostId == postId));

            return new TogglePostLikeRes
            {
                IsLiked = isLiked,
                LikesCount = likesCount
            };
        }
        private async Task<string> GenerateUniqueSlugAsync(string title)
        {
            var baseSlug = FileHelper.GenerateSlug(title);

            var slug = baseSlug;

            int counter = 1;

            while (
                await _unitOfWork.Repository<CommunityPost>()
                .FirstOrDefaultAsync(p => p.Slug == slug)
                is not null)
            {
                slug = $"{baseSlug}-{counter}";
                counter++;
            }

            return slug;
        }
    }
}
