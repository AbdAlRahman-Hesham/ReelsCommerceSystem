using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IRelatedProductService
{
    Task<ApiResponse<List<GetRelatedProductDto>>> GetRelatedProductsAsync(int currentProductId, int take = 3);
}
