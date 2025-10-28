using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.DTOs.Response.Cart;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface ICartService
{
    public Task<ApiResponse<CartRes>> AddToCartAsync(string userId,AddToCartReq req);

    public ApiResponse<CartRes> GetUserCart(string userId);
    public Task<ApiResponse<CartRes>> UpdateCartAsync(string userId, UpdateCartReq updates);
}
