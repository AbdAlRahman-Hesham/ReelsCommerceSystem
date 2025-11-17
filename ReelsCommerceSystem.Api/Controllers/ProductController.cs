using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.SpecificationsParams;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController : AppBaseController
{
    private readonly IProductsPerBrandService _productsPerBrandService;
    private readonly IProductService _productService;

    public ProductController(IProductsPerBrandService productsPerBrandService,IProductService productService)
    {
        _productsPerBrandService = productsPerBrandService;
        _productService = productService;
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


}
