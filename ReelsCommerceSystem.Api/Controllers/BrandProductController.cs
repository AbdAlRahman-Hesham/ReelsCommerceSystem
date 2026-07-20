using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    [Authorize]
    public class BrandProductController(IBrandProductService _brandProductService, IUnitOfWork _unitOfWork) : AppBaseController
    {

        [HttpGet("products")]
        public async Task<ActionResult<ApiResponse<PaginationResponse<GetBrandProductsRes>>>> GetBrandProducts(
                       [FromQuery] GetBrandProductsParams param)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var brand = await _unitOfWork.Repository<Brand>()
                .FirstOrDefaultAsync(b => b.UserId == userId);

            if (brand == null)
            {
                return NotFound(ApiResponse<PaginationResponse<GetBrandProductsRes>>
                    .ErrorResponse(HttpStatusCode.NotFound, "Brand not found", "البراند غير موجود"));
            }

            var result = await _brandProductService.GetBrandProductsAsync(param, brand.Id);

            return StatusCode(result.StatusCode, result);
        }
        [HttpPost("products")]
        public async Task<ActionResult> AddProduct([FromBody] AddBrandProductReq request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var result = await _brandProductService.AddProductAsync(request, userId);

            return StatusCode(result.StatusCode, result);
        }
        [HttpPost("products/{productId}/images")]
        public async Task<ActionResult> UploadImages(int productId, [FromForm] UploadProductImagesReq request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _brandProductService.UploadImagesAsync(
                productId,
                request.Images,
                userId
            );

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int productId, int imageId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _brandProductService.DeleteImageAsync(productId, imageId, userId);

            return StatusCode(result.StatusCode, result);
        }


        [HttpPatch("products")]
        public async Task<ActionResult> PatchProduct([FromBody] EditProductReq request)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _brandProductService.EditProductAsync(request, userId);

            return StatusCode(result.StatusCode, result);
        }

        [HttpDelete("products/{productId}")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var result = await _brandProductService.DeleteProductAsync(productId, userId);

            return StatusCode(result.StatusCode, result);
        }
    }
}