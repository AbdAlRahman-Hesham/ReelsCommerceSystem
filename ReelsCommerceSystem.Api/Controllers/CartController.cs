using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers;
[Authorize]
public class CartController(ICartService _cartservice,ICartCacheService _cartCacheService) : AppBaseController
{
    [HttpGet]
    public IActionResult GetCartByUser()
    {
        var UserId= User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(UserId))
            return Unauthorized(new { message = "User not authenticated" });
        var response = _cartservice.GetUserCart(UserId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart([FromBody] AddToCartReq request)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(new { message = "User not authenticated" });


        var response = await _cartservice.AddToCartAsync(userId, request);

        return StatusCode(response.StatusCode,response);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCart([FromBody] UpdateCartReq request)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (string.IsNullOrEmpty(userId))
            return Unauthorized(new { message = "User not authenticated" });

        var response = await _cartservice.UpdateCartAsync(userId, request);

        return StatusCode(response.StatusCode, response);
    }
    [HttpDelete]
    public IActionResult ClearCart([FromQuery] int? brandId = null)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized();

        if (brandId.HasValue)
            _cartCacheService.ClearCartBrand(userId, brandId.Value);
        else
            _cartCacheService.ClearCart(userId);

        return Ok(ApiResponse<object>.SuccessResponse(
            null,
            HttpStatusCode.OK,
            "Cart cleared successfully",
            "تم حذف عربة التسوق بنجاح"
        ));
    }


}
