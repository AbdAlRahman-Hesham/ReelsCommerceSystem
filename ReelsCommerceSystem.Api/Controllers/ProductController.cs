using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.Reviews;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController(IGenericRepository<ProductReview> productReviewRepository, IProductService productService, IRelatedProductService relatedProductService, IUserProductViewService userProductViewService, IProductRecommendationService productRecommendationService) : AppBaseController
{
    private readonly IProductService _productService = productService;
    private readonly IRelatedProductService _relatedProductService = relatedProductService;
    private readonly IUserProductViewService _userProductViewService = userProductViewService;
    private readonly IGenericRepository<ProductReview> _productReviewRepository = productReviewRepository;
    private readonly IProductRecommendationService _productRecommendationService = productRecommendationService;


 
    [HttpGet]
    public async Task<IActionResult> GetAllProducts([FromQuery] ProductSpecParams specParams)
    {
        var response = await _productService.GetProductsAsync(specParams);
        return StatusCode(response.StatusCode, response);
    }
    [HttpGet("GetAllForAi")]
    public async Task<IActionResult> GetAllProductsForAi()
    {
        var response = await _productService.GetAllProductsForAiAsync();
        return StatusCode(response.StatusCode, response);
    }
    [HttpGet("our-favourites")]
    public async Task<IActionResult> GetOurFavourites()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var recommendedProducts = await _productRecommendationService.GetRecommendedProductsAsync(userId, 20);

        var response = ApiResponse<List<GetAllProductsResponse>>.SuccessResponse(
            recommendedProducts,
            HttpStatusCode.OK
        );

        return Ok(response);
    }
    [HttpGet("{productId}")]
    public async Task<IActionResult> GetProduct(int productId)
    {
        var response = await _productService.GetProductAsync(productId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("related/{productId}")]
    public async Task<IActionResult> GetRelated(int productId)
    {
        var response = await _relatedProductService.GetRelatedProductsAsync(productId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("categories")]
    public async Task<IActionResult> GetProductCategories()
    {
        var response = await _productService.GetProductCategoriesAsync();
        return StatusCode(response.StatusCode, response);
    }

    [Authorize] 
    [HttpGet("recentviews")]
    public async Task<IActionResult> GetRecentViews()
    {
        
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(userId))
            return Unauthorized(new { message = "User not authenticated" });

       
        var recentViews = await _userProductViewService.GetRecentViewsAsync(userId, 5);

        return Ok(recentViews);
    }


[Authorize]
[HttpPost("view/{productId}")]
public async Task<IActionResult> TrackProductView(int productId)
{
  
    var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

    if (string.IsNullOrEmpty(userId))
        return Unauthorized(new { message = "User not authenticated" });

    await _userProductViewService.RecordProductViewAsync(userId, productId);

    return Ok(new { message = "Product view recorded successfully" });
}

    [HttpGet("GetReviewsForProduct")]
    public async Task<IActionResult> GetReviewsForProduct(int productId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        var result = await _productReviewRepository.GetAllWithSpecAsync(new ReviewsPerProductSpec(productId));

        var res = result.Select(r => new ProductReviewRes
        {
            ReviewId = r.Id,
            Rating = r.Rating,
            Comment = r.Comment,
            CreatedAt = r.CreatedAt,
            NumOfLikes = r.NumOfLikes,
            NumOfDislikes = r.NumOfDislikes,
            UserDisplayName = r.User.DisplayName,
            UserImageUrl = r.User.ImageURL,
            IsLike = userId != null && r.Likes.Any(l => l.UserId == userId),
            IsDislike = userId != null && r.Dislikes.Any(d => d.UserId == userId)
        }).ToList();

        var genaricRes = ApiResponse<List<ProductReviewRes>>.SuccessResponse(res, HttpStatusCode.OK);
        return Ok(genaricRes);
    }

    [Authorize]
    [HttpPost("ToggleLikeToReview")]
    public async Task<IActionResult> ToggleLikeToReview([FromBody] ProductToggleLikeReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var result = await _productService.ProductReviewLikeAsync(userId, req);
        var messageEn = result.IsLiked
                ? "Like added successfully."
                : "Like removed successfully.";

        var messageAr = result.IsLiked
            ? "تم إضافة الإعجاب بنجاح."
            : "تم إزالة الإعجاب بنجاح.";

        var response = ApiResponse<ProductToggleLikeRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            messageEn,
            messageAr
        );

        return Ok(response);
    }

    [Authorize]
    [HttpPost("ToggleDislikeToReview")]
    public async Task<IActionResult> ToggleDislikeToReview([FromBody] ProductToggleDislikeReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var result = await _productService.ProductReviewDislikeAsync(userId, req);
        var messageEn = result.IsDisliked
                ? "Dislike added successfully."
                : "Dislike removed successfully.";

        var messageAr = result.IsDisliked
            ? "تم إضافة عدم الإعجاب بنجاح."
            : "تم إزالة عدم الإعجاب بنجاح.";

        var response = ApiResponse<ProductToggleDislikeRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            messageEn,
            messageAr
        );

        return Ok(response);
    }

    [Authorize]
    [HttpPost("{productId}/review")]
    public async Task<IActionResult> AddOrUpdateReview(
        int productId,
        [FromBody] ProductReviewReq dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
        {
            return Unauthorized(
                ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    "Unauthorized.",
                    "غير مصرح."
                ));
        }

        var result = await _productService.AddOrUpdateProductReview(productId, userId, dto);

        return StatusCode(result.StatusCode, result);
    }

    [HttpGet("{productId}/average-rating")]
    public async Task<IActionResult> GetAverageRating(int productId)
    {
        var result = await _productService.GetProductAverageRating(productId);
        return StatusCode(result.StatusCode, result);
    }
}
