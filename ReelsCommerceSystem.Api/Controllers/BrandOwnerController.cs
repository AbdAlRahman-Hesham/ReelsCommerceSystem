using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers;

public class BrandOwnerController(IBrandService _brandService) : AppBaseController
{
    [HttpGet("{brandId}")]
    public async Task<IActionResult> GetBrandOwner(int brandId)
    {
        var result = await _brandService.GetBrandOwnerAsync(brandId);
        return StatusCode(result.StatusCode, result);
    }
}
