using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using ReelsCommerceSystem.Application.DTOs.Request.Community;
using ReelsCommerceSystem.Application.DTOs.Response.Community;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.CommunityEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.Community;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class PostCommentService(IUnitOfWork _unitOfWork
        , UserManager<User> _userManager) : IPostCommentService
    {
        public async Task<PostCommentRes> GetCommentByIdAsync(int commentId, string userId)
        {
            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException("This service only for brand owners");

            var comment = await _unitOfWork.Repository<PostComment>()
                .GetWithSpecAsync(new CommentByIdSpec(commentId));

            if (comment is null)
                throw new NotFoundException("Comment not found");

            return MapComment(comment, brand.Id);
        }

        public async Task<IEnumerable<PostCommentRes>> GetPostCommentsAsync(int postId, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
                throw new NotFoundException("User not found");

            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException("This service only for brand owners");

            var comments = await _unitOfWork.Repository<PostComment>()
                .GetAllWithSpecAsync(new PostCommentsSpec(postId));

            var result = comments
                .Where(c => c.ParentCommentId == null)
                .Select(c => MapComment(c, brand.Id))
                .ToList();

            return result;
        }

        public async Task<int> CreateCommentAsync(CreatePostCommentReq req, string userId)
        {
            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException("This service only for brand owners");

            var post = await _unitOfWork.Repository<CommunityPost>().GetByIdAsync(req.PostId);

            if (post is null)
                throw new NotFoundException("Post not found");

            if (!post.CommentsEnabled)
                throw new BadRequestException(
                    "Comments are disabled for this post");

            if (string.IsNullOrWhiteSpace(req.Content))
                throw new BadRequestException("Content is required");

            if (req.ParentCommentId.HasValue)
            {
                var parentComment = await _unitOfWork
                    .Repository<PostComment>()
                    .GetByIdAsync(req.ParentCommentId.Value);

                if (parentComment is null)
                    throw new NotFoundException(
                        "Parent comment not found");

                if (parentComment.PostId != req.PostId)
                    throw new BadRequestException(
                        "Invalid parent comment");
            }

            var comment = new PostComment
            {
                PostId = req.PostId,

                BrandId = brand.Id,

                Content = req.Content,

                ParentCommentId = req.ParentCommentId
            };

            await _unitOfWork.Repository<PostComment>().AddAsync(comment);

            await _unitOfWork.SaveChangesAsync();

            return comment.Id;
        }

        public async Task UpdateCommentAsync(UpdatePostCommentReq req,string userId)
        {
            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException("This service only for brand owners");

            var comment = await _unitOfWork.Repository<PostComment>()
                .GetByIdAsync(req.CommentId);

            if (comment is null)
                throw new NotFoundException("Comment not found");

            if (comment.BrandId != brand.Id)
                throw new UnauthorizedException();

            if (string.IsNullOrWhiteSpace(req.Content))
                throw new BadRequestException("Content is required");

            comment.Content = req.Content;

            _unitOfWork.Repository<PostComment>()
                .Update(comment);

            await _unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteCommentAsync(int commentId,string userId)
        {
            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException("This service only for brand owners");

            var comment = await _unitOfWork.Repository<PostComment>()
                .GetByIdAsync(commentId);

            if (comment is null)
                throw new NotFoundException("Comment not found");

            if (comment.BrandId != brand.Id)
                throw new UnauthorizedException();

            await DeleteCommentTree(comment);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<ToggleCommentLikeRes>ToggleCommentLikeAsync(int commentId, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
                throw new NotFoundException("User not found");

            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand is null)
                throw new BadRequestException(
                    "This service for brand owners only");

            var comment = await _unitOfWork.Repository<PostComment>()
                .GetByIdAsync(commentId);

            if (comment is null)
                throw new NotFoundException("Comment not found");

            var likeSpec = new Specification<PostCommentLike>(
                l => l.BrandId == brand.Id
                  && l.PostCommentId == commentId);

            var existingLike = await _unitOfWork
                .Repository<PostCommentLike>()
                .GetWithSpecAsync(likeSpec);

            bool isLiked;

            if (existingLike is null)
            {
                await _unitOfWork.Repository<PostCommentLike>()
                    .AddAsync(new PostCommentLike
                    {
                        BrandId = brand.Id,
                        PostCommentId = commentId
                    });

                isLiked = true;
            }
            else
            {
                _unitOfWork.Repository<PostCommentLike>()
                    .Delete(existingLike);

                isLiked = false;
            }

            await _unitOfWork.SaveChangesAsync();

            var likesCount = await _unitOfWork
                .Repository<PostCommentLike>()
                .CountAsync(new Specification<PostCommentLike>(
                    l => l.PostCommentId == commentId));

            return new ToggleCommentLikeRes
            {
                IsLiked = isLiked,
                LikesCount = likesCount
            };
        }


        private async Task DeleteCommentTree(PostComment comment)
        {
            var replies = await _unitOfWork.Repository<PostComment>()
                .GetAllWithSpecAsync(new Specification<PostComment>
                (c => c.ParentCommentId == comment.Id) );

            foreach (var reply in replies)
            {
                await DeleteCommentTree(reply);
            }

            _unitOfWork.Repository<PostComment>().Delete(comment);
        }

        private PostCommentRes MapComment(PostComment comment, int brandId)
        {
            return new PostCommentRes
            {
                CommentId = comment.Id,

                BrandName = comment.Brand?.DisplayName ?? "",

                BrandOwnerName = comment.Brand?.user?.DisplayName ?? "",

                BrandLogoUrl = comment.Brand?.LogoUrl ?? "",

                BrandOwnerImageUrl = comment.Brand?.user?.ImageURL ?? "",

                CreatedAt = comment.CreatedAt,

                Content = comment.Content,

                LikesCount = comment.CommentLikes?.Count ?? 0,

                RepliesCount = comment.Replies?.Count ?? 0,

                Isliked = comment.CommentLikes?
                    .Any(x => x.BrandId == brandId) ?? false,

                Replies = comment.Replies?
                    .OrderByDescending(r => r.CreatedAt)
                    .Select(r => MapComment(r, brandId))
                    .ToList()
                    ?? []
            };
        }
    }
}
