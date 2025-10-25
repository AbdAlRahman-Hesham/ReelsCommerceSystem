using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.DTOs.Response.Cart;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class CartService : ICartService
{
    private readonly ICartCacheService _cartCache;
    private readonly IGenericRepository<Product> _productRepo;

    public CartService(ICartCacheService cartCache, IGenericRepository<Product> productRepo)
    {
        _cartCache = cartCache;
        _productRepo = productRepo;
    }

    public async Task<ApiResponse<CartRes>> AddToCartAsync(AddToCartReq req)
    {
        var product = await _productRepo.GetByIdAsync(req.productId);
        if (product == null)
            return ApiResponse<CartRes>.ErrorResponse(HttpStatusCode.NotFound, en: "Product not found.", "لم يتم العثور على ");

        var cart = _cartCache.GetCart(req.userId) ?? new Cart { UserId = req.userId };

        var existing = cart.ProductCarts.FirstOrDefault(p => p.ProductId == req.productId);
        if (existing != null)
            existing.Quantity += req.quantity;
        else
        {
            cart.ProductCarts.Add(new ProductCart
            {
                ProductId = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price * ( product.DiscountPercentage?? 1),
                Category = product.Category,
                MediaUrl = product.MediaUrl,
                Quantity = req.quantity
            });
        }

        _cartCache.SaveCart(req.userId, cart);

        var cartRes = new CartRes
        {
            CartId = cart.Id,
            UserId = req.userId,
            CartItems = cart.ProductCarts.Select(ci => new CartItemRes
            {
                ProductId = ci.ProductId,
                ProductName = ci.Name,
                ProductMediaUrl = ci.MediaUrl,
                ProductPrice = ci.Price * (product.DiscountPercentage ?? 1),
                Quantity = ci.Quantity
            }).ToList()
        };

        return ApiResponse<CartRes>.SuccessResponse(cartRes, HttpStatusCode.OK, en: "Added to cart.","تم اضافة عربة التسوق بنجاح");
    }

    public ApiResponse<CartRes> GetUserCart(string userId)
    {
        var cart = _cartCache.GetCart(userId);
        if (cart == null)
            return ApiResponse<CartRes>.ErrorResponse(HttpStatusCode.NotFound, en: "Cart not found.","لم يتم العثور على عربة التسوق");

        var res = new CartRes
        {
            CartId = cart.Id,
            UserId = userId,
            CartItems = cart.ProductCarts.Select(ci => new CartItemRes
            {
                ProductId = ci.ProductId,
                ProductName = ci.Name,
                ProductMediaUrl = ci.MediaUrl,
                ProductPrice = ci.Price,
                Quantity = ci.Quantity
            }).ToList()
        };

        return ApiResponse<CartRes>.SuccessResponse(res, HttpStatusCode.OK, en: "Cart fetched.", "تم جلب عربة التسوق");
    }
}