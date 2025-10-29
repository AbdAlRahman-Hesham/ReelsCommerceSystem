using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.SpecificationsParams;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController : AppBaseController
{
    private readonly IProductsPerBrandService _productsPerBrandService;
    private readonly IProductService _productService;
    private readonly IRelatedProductService _relatedProductService;

    public ProductController(IProductsPerBrandService productsPerBrandService,IProductService productService,IRelatedProductService relatedProductService)
    {
        _productsPerBrandService = productsPerBrandService;
        _productService = productService;
        _relatedProductService = relatedProductService;
    }


    [HttpGet("ProductsForBrand")]
    public async Task<IActionResult> GetProductsPerBrand([FromQuery] ProductsPerBrandSpecParams productsPerBrandSpecParams)
    {
        var response = await _productsPerBrandService.GetProductsPerBrandAsync(productsPerBrandSpecParams);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts([FromQuery] ProductSpecParams specParams)
    {
        var response = await _productService.GetProductsAsync(specParams);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("related/{productId}")]
    public async Task<IActionResult> GetRelated(int productId)
    {
        var response = await _relatedProductService.GetRelatedProductsAsync(productId);
        return StatusCode(response.StatusCode, response);
    }



}
