using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController : AppBaseController
{
    private readonly IProductService _productService;
    private readonly IRelatedProductService _relatedProductService;

    public ProductController(IProductService productService,IRelatedProductService relatedProductService)
    {
        _productService = productService;
        _relatedProductService = relatedProductService;
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
}
