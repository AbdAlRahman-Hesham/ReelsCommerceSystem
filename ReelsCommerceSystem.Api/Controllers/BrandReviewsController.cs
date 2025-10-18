using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications;
using ReelsCommerceSystem.Shared.Responses;


namespace ReelsCommerceSystem.Api.Controllers;

public class BrandReviewController(IGenericRepository<BrandReview> brandReviewRepository) :AppBaseController
{
    private readonly IGenericRepository<BrandReview> _brandReviewRepository = brandReviewRepository;

    [HttpGet("GetReviewsForBrand")]
    public async Task<IActionResult> GetReviewsForBrand(int brandId)
    {
        var result = await _brandReviewRepository.GetAllWithSpecAsync(new ReviewsPerBrandSpec(brandId));

        var res = result.Select(r => new BrandReviewRes
        {
            ReviewId = r.Id,
            Rating = r.Rating,
            Comment = r.Comment,
            CreatedAt = r.CreatedAt,
            NumOfLikes = r.numOfLikes,
            NumOfDislikes = r.numOfDislikes,
            UserDisplayName = r.User.DisplayName,
            UserImageUrl = r.User.ImageURL
        }).ToList();


        var genaricRes = ApiResponse<List<BrandReviewRes>>.SuccessResponse(res, System.Net.HttpStatusCode.OK);
        return Ok(genaricRes);
    }


    [Authorize]
    [HttpPost("ToggleLikeToReview")]
    public async Task<IActionResult> ToggleLikeToReview()
    {

        return Ok();
    }

}
