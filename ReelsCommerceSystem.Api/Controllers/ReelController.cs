using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class ReelController(IReelService _reelService) :AppBaseController
    {
        [HttpGet("{brandId}")]
        public async Task<IActionResult> GetReelsByBrand(int brandId, [FromQuery] string? sortBy = null)
        {
            var response = await _reelService.GetReelsByBrandAsync(brandId, sortBy);
            return StatusCode(response.StatusCode, response);
        }
    }
}
