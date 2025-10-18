using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.SpecificationsParams;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class ProductController : AppBaseController
    {
        private readonly IProductsPerBrandService _productsPerBrandService;

        public ProductController(IProductsPerBrandService productsPerBrandService)
        {
            _productsPerBrandService = productsPerBrandService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProductsPerBrand([FromQuery] ProductsPerBrandSpecParams productsPerBrandSpecParams)
        {
            var response = await _productsPerBrandService.GetProductsPerBrandAsync(productsPerBrandSpecParams);
            return StatusCode(response.StatusCode, response);
        }
    }
}
