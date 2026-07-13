using ReelsCommerceSystem.Application.DTOs.Request.Category;
using ReelsCommerceSystem.Application.DTOs.Response.Product;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface ICategoryService
{
    Task<IEnumerable<ProductCategoryResponse>> GetAllAsync();
    Task<ProductCategoryResponse?> GetByIdAsync(int id);
    Task<ProductCategoryResponse> CreateAsync(CategoryReqDto request);
    Task<ProductCategoryResponse?> UpdateAsync(int id, CategoryReqDto request);
    Task<bool> DeleteAsync(int id);
}
