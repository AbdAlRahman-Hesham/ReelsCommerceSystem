using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

public class BrandController (IBrandService _brandService, IGenericRepository<BrandReview> _brandReviewRepository) : AppBaseController
{
    [HttpGet("BrandPolicy")]
    public async Task<IActionResult> GetBrandPolicy([FromQuery]int id)
    {
        var policyHtml = await _brandService.GetBrandPolicyAsync(id);
        if (policyHtml == null)
            return NotFound(
        ApiResponse<BrandPolicyRes>.ErrorResponse(
            HttpStatusCode.NotFound,
            "Brand not found.",
            "العلامة التجارية غير موجودة."
        ));

        var response = new BrandPolicyRes
        {
            BrandId = id,
            ReturnPolicyAsHtml = policyHtml
        };

            return Ok(
            ApiResponse<BrandPolicyRes>.SuccessResponse(
                response,
                HttpStatusCode.OK,
                "Brand policy retrieved successfully.",
                "تم جلب سياسة الاسترجاع بنجاح."));
        }
    
    [HttpGet("BrandInfo/{brandId}")]
    public async Task<IActionResult> GetBrandInfo(int brandId)
    {
        var result = await _brandService.GetBrandInfoAsync(brandId);
        return StatusCode(result.StatusCode, result);
    }

    [HttpGet("GetReviewsForBrand")]
    public async Task<IActionResult> GetReviewsForBrand(int brandId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        Console.WriteLine("UserID = " + userId);

        var result = await _brandReviewRepository.GetAllWithSpecAsync(new ReviewsPerBrandSpec(brandId));

        var res = result.Select(r => new BrandReviewRes
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


        var genaricRes = ApiResponse<List<BrandReviewRes>>.SuccessResponse(res, HttpStatusCode.OK);
        return Ok(genaricRes);
    }

    [Authorize]
    [HttpPost("ToggleLikeToReview")]
    public async Task<IActionResult> ToggleLikeToReview([FromBody] ToggleLikeReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var result = await _brandService.BrandReviewLikeAsync(userId, req);
        var messageEn = result.IsLiked
                ? "Like added successfully."
                : "Like removed successfully.";

        var messageAr = result.IsLiked
            ? "تم إضافة الإعجاب بنجاح."
            : "تم إزالة الإعجاب بنجاح.";

        var response = ApiResponse<ToggleLikeRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            messageEn,
            messageAr
        );


        return Ok(response);
    }
    
    [Authorize]
    [HttpPost("ToggleDislikeToReview")]
    public async Task<IActionResult> ToggleDislikeToReview([FromBody] ToggleDislikeReq req)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        var result = await _brandService.BrandReviewDislikeAsync(userId, req);
        var messageEn = result.IsDisliked
                ? "Dislike added successfully."
                : "Dislike removed successfully.";

        var messageAr = result.IsDisliked
            ? "تم إضافة عدم الاعجاب بنجاح."
            : "تم إزالة عدم الاعجاب بنجاح.";

        var response = ApiResponse<ToggleDislikeRes>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            messageEn,
            messageAr
        );


        return Ok(response);
    }
   
    [Authorize]
    [HttpPost("ToggleFollow/{brandId}")]
    public async Task<IActionResult> ToggleFollowBrand(int brandId)
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;  ////


        if (string.IsNullOrEmpty(userId))
        {
            return StatusCode((int)HttpStatusCode.Unauthorized,
                ApiResponse<string>.ErrorResponse(HttpStatusCode.Unauthorized, "Unauthorized user.", "المستخدم غير مصرح له."));
        }

        var response = await _brandService.ToggleFollowAsync(brandId, userId);

        return StatusCode(response.StatusCode, response);
    }

    [Authorize]
    [HttpPost("{brandId}/review")]
    public async Task<IActionResult> AddOrUpdateReview(
        int brandId,
        [FromBody] BrandReviewReq dto)
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
        
        var result = await _brandService
           .AddOrUpdateReview(brandId, userId, dto);

        return StatusCode(result.StatusCode, result);

    }


}
