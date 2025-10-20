using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.SpecificationsParams;

namespace ReelsCommerceSystem.Api.Controllers;

public class ProductController : AppBaseController
{
    private readonly IProductsPerBrandService _productsPerBrandService;

    public ProductController(IProductsPerBrandService productsPerBrandService)
    {
        _productsPerBrandService = productsPerBrandService;
    }


    [HttpGet("ProductsForBrand")]
    public async Task<IActionResult> GetProductsPerBrand([FromQuery] ProductsPerBrandSpecParams productsPerBrandSpecParams)
    {
        var response = await _productsPerBrandService.GetProductsPerBrandAsync(productsPerBrandSpecParams);
        return StatusCode(response.StatusCode, response);
    }
}
