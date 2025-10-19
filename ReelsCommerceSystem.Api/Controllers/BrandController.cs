using System.Net;
using Azure;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class BrandController (IBrandService _brandService): AppBaseController
    {
        [HttpGet("BrandPolicy")]
        public async Task<IActionResult> GetBrandPolicy([FromQuery]int id)
        {
            var policyHtml = await _brandService.GetBrandPolicyAsync(id);
            if (policyHtml == null)
                return NotFound(
            ApiResponse<BrandPolicyRes>.ErrorResponse(
                HttpStatusCode.NotFound,
                "Brand not found.",
                "العلامة التجارية غير موجودة."
            ));

            var response = new BrandPolicyRes
            {
                BrandId = id,
                ReturnPolicyAsHtml = policyHtml
            };

            return Ok(
            ApiResponse<BrandPolicyRes>.SuccessResponse(
                response,
                HttpStatusCode.OK,
                "Brand policy retrieved successfully.",
                "تم جلب سياسة الاسترجاع بنجاح."));
        }
        [HttpGet("BrandInfo/{brandId}")]
        public async Task<IActionResult> GetBrandInfo(int brandId)
        {
            var result = await _brandService.GetBrandInfoAsync(brandId);
            return StatusCode(result.StatusCode, result);
        }

    }
}
