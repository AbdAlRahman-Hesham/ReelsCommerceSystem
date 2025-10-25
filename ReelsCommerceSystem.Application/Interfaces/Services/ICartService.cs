using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.DTOs.Response.Cart;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ICartService
    {
        Task<ApiResponse<CartRes>> GetUserCartAsync(string userId);
        Task<ApiResponse<CartRes>> AddToCartAsync(AddToCartReq addToCartReq);
    }
}
