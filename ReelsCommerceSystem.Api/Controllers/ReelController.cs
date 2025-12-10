using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;

namespace ReelsCommerceSystem.Api.Controllers;

public class ReelController(IReelService _reelService,IReelAnalyticsService _reelAnalyticsService) :AppBaseController
{
    [HttpGet("{brandId}")]
    public async Task<IActionResult> GetReelsByBrand(int brandId, [FromQuery] string? sortBy = null)
    {
        var response = await _reelService.GetReelsByBrandAsync(brandId, sortBy);
        return StatusCode(response.StatusCode, response);
    }



    [HttpGet("topbrands")]
    public async Task<IActionResult> GetTopBrands([FromQuery] int topN = 5)
    {
        if (topN <= 0)
            return BadRequest(new { message = "The number of top brands must be greater than zero." });

        var topBrands = await _reelAnalyticsService.GetTopBrandsLastWeekAsync(topN);

        return Ok(new
        {
            topN,
            brands = topBrands
        });
    }


  
    }

