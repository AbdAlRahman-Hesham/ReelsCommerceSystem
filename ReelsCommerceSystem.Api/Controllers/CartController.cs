using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers;

public class CartController(ICartService _cartservice) : AppBaseController
{
    [HttpGet("{userId}")]
    public IActionResult GetCartByUser(string userId)
    {
        var response = _cartservice.GetUserCart(userId);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart([FromBody] AddToCartReq request)
    {
        var response = await _cartservice.AddToCartAsync(request);
        return StatusCode(response.StatusCode, response);
    }

}
