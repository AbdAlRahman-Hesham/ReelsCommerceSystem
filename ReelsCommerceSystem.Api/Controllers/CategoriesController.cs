using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Dto;
using ReelsCommerceSystem.Application.DTOs.Request.Category;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

public class CategoriesController(ICategoryService categoryService, IPhotoServive photoService) : AppBaseController
{
    private readonly ICategoryService _categoryService = categoryService;
    private readonly IPhotoServive _photoService = photoService;

    [HttpGet]
    public async Task<ActionResult<ApiResponse<IEnumerable<ProductCategoryResponse>>>> GetAll()
    {
        var result = await _categoryService.GetAllAsync();
        return Ok(ApiResponse<IEnumerable<ProductCategoryResponse>>.SuccessResponse(result, HttpStatusCode.OK, "Categories retrieved successfully", "تم جلب التصنيفات بنجاح"));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<ProductCategoryResponse>>> GetById(int id)
    {
        var result = await _categoryService.GetByIdAsync(id);
        if (result == null) return NotFound(ApiResponse<ProductCategoryResponse>.ErrorResponse(HttpStatusCode.NotFound, "Category not found", "التصنيف غير موجود"));
        return Ok(ApiResponse<ProductCategoryResponse>.SuccessResponse(result, HttpStatusCode.OK, "Category retrieved successfully", "تم جلب التصنيف بنجاح"));
    }

    [Authorize]
    [HttpPost("upload-image")]
    public async Task<ActionResult<ApiResponse<PhotoUploadResult>>> UploadImage(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest(ApiResponse<PhotoUploadResult>.ErrorResponse(HttpStatusCode.BadRequest, "No file uploaded", "لم يتم رفع ملف"));

        var result = await _photoService.UploadImageForCategoryAsync(file);
        if (result == null)
            return BadRequest(ApiResponse<PhotoUploadResult>.ErrorResponse(HttpStatusCode.BadRequest, "Upload failed", "فشل الرفع"));

        return Ok(ApiResponse<PhotoUploadResult>.SuccessResponse(result, HttpStatusCode.OK, "Image uploaded successfully", "تم رفع الصورة بنجاح"));
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<ApiResponse<ProductCategoryResponse>>> Create([FromBody] CategoryReqDto request)
    {
        var result = await _categoryService.CreateAsync(request);
        return Ok(ApiResponse<ProductCategoryResponse>.SuccessResponse(result, HttpStatusCode.OK, "Category created successfully", "تم إنشاء التصنيف بنجاح"));
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<ProductCategoryResponse>>> Update(int id, [FromBody] CategoryReqDto request)
    {
        var result = await _categoryService.UpdateAsync(id, request);
        if (result == null) return NotFound(ApiResponse<ProductCategoryResponse>.ErrorResponse(HttpStatusCode.NotFound, "Category not found", "التصنيف غير موجود"));
        return Ok(ApiResponse<ProductCategoryResponse>.SuccessResponse(result, HttpStatusCode.OK, "Category updated successfully", "تم تحديث التصنيف بنجاح"));
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<ActionResult<ApiResponse<bool>>> Delete(int id)
    {
        var result = await _categoryService.DeleteAsync(id);
        if (!result) return NotFound(ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Category not found", "التصنيف غير موجود"));
        return Ok(ApiResponse<bool>.SuccessResponse(true, HttpStatusCode.OK, "Category deleted successfully", "تم حذف التصنيف بنجاح"));
    }
}
