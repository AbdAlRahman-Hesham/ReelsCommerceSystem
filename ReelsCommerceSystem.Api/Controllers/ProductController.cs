using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Services;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController : AppBaseController
{
    private readonly IProductService _productService;
    private readonly IRelatedProductService _relatedProductService;
    private readonly IUserProductViewService _userProductViewService;

    public ProductController(IProductService productService,IRelatedProductService relatedProductService,IUserProductViewService userProductViewService)
    {
        _productService = productService;
        _relatedProductService = relatedProductService;
        _userProductViewService = userProductViewService;
    }


 
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


}
