using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.DTOs.Response.Cart;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class CartService : ICartService
{
    private readonly ICartCacheService _cartCache;
    private readonly IGenericRepository<Product> _productRepo;
    private readonly UserManager<User> _userManager;


    public CartService(ICartCacheService cartCache, IGenericRepository<Product> productRepo, UserManager<User> userManager)
    {
        _cartCache = cartCache;
        _productRepo = productRepo;
        _userManager = userManager;
    }

    public async Task<ApiResponse<CartRes>> AddToCartAsync(string userId,AddToCartReq req)
    {
        if (req.Items == null || !req.Items.Any())
            return ApiResponse<CartRes>.ErrorResponse(HttpStatusCode.BadRequest, en: "No products provided.", "لم يتم إرسال أي منتجات.");

        var cart = _cartCache.GetCart(userId) ?? new Cart { UserId = userId };

        foreach (var item in req.Items)
        {
            var productSpc = new Specification<Product>(criteria: p=>p.Id == item.ProductId)
            {
                Includes = [p=>p.Category]
            };

            var product = await _productRepo.GetWithSpecAsync(productSpc);

            if (product == null)
                continue; 

            var existing = cart.ProductCarts.FirstOrDefault(p => p.ProductId == item.ProductId &&
                                                                p.Color == item.Color &&
                                                                p.Size.ToString().ToLower() == item.Size.ToLower());
            if (existing != null)
                existing.Quantity += item.Quantity;
            else
            {
                cart.ProductCarts.Add(new CartProduct
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price * (1 - ((product.DiscountPercentage ?? 0) / 100m)),
                    Category = product.Category.Name,
                    MediaUrl = product.MediaUrl,
                    Quantity = item.Quantity,
                    Size = Enum.Parse<Domain.Enums.Size>(item.Size, true),
                    Color = item.Color
                });
            }
        }

        _cartCache.SaveCart(userId, cart);
        var updatedCart = _cartCache.GetCart(userId);

        var cartRes = new CartRes
        {
            CartId = updatedCart.Id,
            UserId = userId,
            CartItems = updatedCart.ProductCarts.Select(ci => new CartItemRes
            {
                ProductId = ci.ProductId,
                ProductName = ci.Name,
                ProductMediaUrl = ci.MediaUrl,
                ProductPrice = ci.Price,
                Quantity = ci.Quantity,
                Color = ci.Color ?? string.Empty,
                Size = ci.Size.ToString()
            }).ToList()
        };

        return ApiResponse<CartRes>.SuccessResponse(cartRes, HttpStatusCode.OK, en: "Products added to cart successfully.", "تمت إضافة المنتجات إلى عربة التسوق بنجاح");
    }

    public ApiResponse<CartRes> GetUserCart(string userId)
    {
        var cart = _cartCache.GetCart(userId);
        if (cart == null || cart.ProductCarts == null || !cart.ProductCarts.Any())
            return ApiResponse<CartRes>.ErrorResponse(
                HttpStatusCode.NotFound,
                en: "Your cart is empty.",
                ar: "عربة التسوق فارغة."
            );

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
                Quantity = ci.Quantity,
                Color = ci.Color ?? string.Empty,
                Size = ci.Size.ToString()
            }).ToList()
        };

        return ApiResponse<CartRes>.SuccessResponse(res, HttpStatusCode.OK, en: "Cart fetched.", "تم جلب عربة التسوق");
    }

    public async Task<ApiResponse<CartRes>> UpdateCartAsync(string userId, UpdateCartReq updates)
    {
        var cart = _cartCache.GetCart(userId) ?? new Cart { UserId = userId };
        if (cart == null)
            return ApiResponse<CartRes>.ErrorResponse(HttpStatusCode.NotFound, en: "Cart not found.", "لم يتم العثور على عربة التسوق");

        foreach (var update in updates.Items)
        {
            var item = cart.ProductCarts.FirstOrDefault(p => p.ProductId == update.ProductId && 
                                                                p.Color == update.Color && 
                                                                p.Size.ToString().ToLower() == update.Size.ToLower());

            if (item == null && (!update.Quantity.HasValue || update.Quantity.Value <= 0) &&
            (!update.Change.HasValue || update.Change.Value <= 0))
                continue;


            if (item == null)
            {
                var productSpc = new Specification<Product>(criteria: p => p.Id == update.ProductId)
                {
                    Includes = [p => p.Category]
                };

                var product = await _productRepo.GetWithSpecAsync(productSpc);
                if (product == null) continue;

                int initialQuantity;

                if (update.Quantity.HasValue && update.Quantity.Value > 0)
                    initialQuantity = update.Quantity ?? 0;
                else if (update.Change.HasValue && update.Change.Value > 0)
                    initialQuantity = update.Change.Value;
                else
                    initialQuantity = 0;


                if (initialQuantity <= 0) continue;

                cart.ProductCarts.Add(new CartProduct
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price * (1 - ((product.DiscountPercentage ?? 0) / 100m)),
                    Category = product.Category.Name,
                    MediaUrl = product.MediaUrl,
                    Quantity = initialQuantity,
                    Color = update.Color,
                    Size = Enum.Parse<Domain.Enums.Size>(update.Size, true),
                    
                });
            }
            else
            {
                if (update.Change.HasValue && update.Change.Value != 0)
                    item.Quantity += update.Change.Value;

                else if (update.Quantity.HasValue)
                    item.Quantity = update.Quantity.Value;

                if (item.Quantity <= 0)
                    cart.ProductCarts.Remove(item);
            }
        }
        

        _cartCache.SaveCart(userId, cart);
        var updatedCart = _cartCache.GetCart(userId);

        var res = new CartRes
        {
            CartId = updatedCart.Id,
            UserId = userId,
            CartItems = updatedCart.ProductCarts.Select(ci => new CartItemRes
            {
                ProductId = ci.ProductId,
                ProductName = ci.Name,
                ProductMediaUrl = ci.MediaUrl,
                ProductPrice = ci.Price,
                Quantity = ci.Quantity,
                Color = ci.Color,
                Size = ci.Size.ToString()
            }).ToList()
        };

        return ApiResponse<CartRes>.SuccessResponse(res, HttpStatusCode.OK,
            en: "Cart updated successfully.", ar: "تم تحديث عربة التسوق بنجاح");
    }

}