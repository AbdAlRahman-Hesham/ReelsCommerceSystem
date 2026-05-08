using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.DiscountCode;
using ReelsCommerceSystem.Application.DTOs.Response.DiscountCode;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Authorize]
public class DiscountCodesController(IDiscountCodeService discountCodeService) : AppBaseController
{
    private readonly IDiscountCodeService _discountCodeService = discountCodeService;

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<DiscountCodeResDto>>>> GetAll()
    {
        var result = await _discountCodeService.GetAllAsync();
        return Ok(ApiResponse<IEnumerable<DiscountCodeResDto>>.SuccessResponse(result, HttpStatusCode.OK, "Discount codes retrieved successfully", "تم جلب أكواد الخصم بنجاح"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<DiscountCodeResDto>>> GetById(int id)
    {
        var result = await _discountCodeService.GetByIdAsync(id);
        if (result == null) return NotFound(ApiResponse<DiscountCodeResDto>.ErrorResponse(HttpStatusCode.NotFound, "Discount code not found", "كود الخصم غير موجود"));
        return Ok(ApiResponse<DiscountCodeResDto>.SuccessResponse(result, HttpStatusCode.OK, "Discount code retrieved successfully", "تم جلب كود الخصم بنجاح"));
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<DiscountCodeResDto>>> Create([FromBody] DiscountCodeReqDto request)
    {
        var result = await _discountCodeService.CreateAsync(request);
        return Ok(ApiResponse<DiscountCodeResDto>.SuccessResponse(result, HttpStatusCode.OK, "Discount code created successfully", "تم إنشاء كود الخصم بنجاح"));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<DiscountCodeResDto>>> Update(int id, [FromBody] DiscountCodeReqDto request)
    {
        var result = await _discountCodeService.UpdateAsync(id, request);
        if (result == null) return NotFound(ApiResponse<DiscountCodeResDto>.ErrorResponse(HttpStatusCode.NotFound, "Discount code not found", "كود الخصم غير موجود"));
        return Ok(ApiResponse<DiscountCodeResDto>.SuccessResponse(result, HttpStatusCode.OK, "Discount code updated successfully", "تم تحديث كود الخصم بنجاح"));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<bool>>> Delete(int id)
    {
        var result = await _discountCodeService.DeleteAsync(id);
        if (!result) return NotFound(ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Discount code not found", "كود الخصم غير موجود"));
        return Ok(ApiResponse<bool>.SuccessResponse(true, HttpStatusCode.OK, "Discount code deleted successfully", "تم حذف كود الخصم بنجاح"));
    }

    [HttpGet("verify/{code}")]
    public async Task<ActionResult<ApiResponse<DiscountCodeResDto>>> Verify(string code)
    {
        var result = await _discountCodeService.VerifyDiscountCodeAsync(code);
        if (result == null) return BadRequest(ApiResponse<DiscountCodeResDto>.ErrorResponse(HttpStatusCode.BadRequest, "Invalid or expired discount code", "كود خصم غير صالح أو منتهي الصلاحية"));
        return Ok(ApiResponse<DiscountCodeResDto>.SuccessResponse(result, HttpStatusCode.OK, "Discount code is valid", "كود الخصم صالح"));
    }
}
