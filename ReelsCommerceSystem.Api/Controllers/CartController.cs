using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Ocsp;
using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Services;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;

public class CartController(ICartService _cartservice) : AppBaseController
{
    [HttpGet]
    [Authorize]
    public IActionResult GetCartByUser()
    {
        var UserId= User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(UserId))
            return Unauthorized(new { message = "User not authenticated" });
        var response = _cartservice.GetUserCart(UserId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> AddToCart([FromBody] AddToCartReq request)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(new { message = "User not authenticated" });


        var response = await _cartservice.AddToCartAsync(userId, request);

        return StatusCode(response.StatusCode,response);
    }

}
