using ReelsCommerceSystem.Application.DTOs.Request.Cart;
using ReelsCommerceSystem.Application.DTOs.Response.Cart;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductCartEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class CartService(IUnitOfWork _unitOfWork) : ICartService
    {
        public  async Task<ApiResponse<CartRes>> AddToCartAsync(AddToCartReq addToCartReq)
        {
            var cartRepo = (ICartRepository)_unitOfWork.Repository<Cart>();
            var productRepo = _unitOfWork.Repository<Product>();

            var product = await productRepo.GetByIdAsync(addToCartReq.productId);

            if (product == null)
            {
                return ApiResponse<CartRes>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    en: "Product not found.",
                    ar: "المنتج غير موجود."
                );
            }
            var userCart = await cartRepo.GetUserCartAsync(addToCartReq.userId);
            if (userCart == null)
            {
                userCart = new Cart
                {
                    UserId = addToCartReq.userId,
                    ProductCarts = new List<ProductCart>
                    {
                        new ProductCart { ProductId = addToCartReq.productId, Quantity = addToCartReq.quantity }
                    }
                };
                await cartRepo.AddCartAsync(userCart);
            }
            else
            {
                var existingItem = userCart.ProductCarts.FirstOrDefault(ci => ci.ProductId == addToCartReq.productId);
                if (existingItem != null)
                    existingItem.Quantity += addToCartReq.quantity;
                else
                    userCart.ProductCarts.Add(new ProductCart { ProductId = addToCartReq.productId, Quantity = addToCartReq.quantity });

                await cartRepo.UpdateCartAsync(userCart);
            }

            await _unitOfWork.SaveChangesAsync();

            var cartRes = new CartRes
            {
                CartId = userCart.Id,
                UserId = userCart.UserId,
                CartItems = userCart.ProductCarts.Select(ci => new CartItemRes
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product?.Name ?? "",
                    ProductMediaUrl = ci.Product?.MediaUrl ?? "",
                    ProductPrice = ci.Product?.Price ?? 0,
                    Quantity = ci.Quantity
                }).ToList()
            };

            return ApiResponse<CartRes>.SuccessResponse(
                cartRes,
                HttpStatusCode.OK,
                en: "Product added to cart successfully.",
                ar: "تمت إضافة المنتج إلى عربة التسوق بنجاح."
            );


        }

        public async Task<ApiResponse<CartRes>> GetUserCartAsync(string userId)
        {
            var cartRepo = _unitOfWork.Repository<Cart>();
            var cart = await((ICartRepository)cartRepo).GetUserCartAsync(userId);
            if (cart == null) 
            {
                return ApiResponse<CartRes>.ErrorResponse
                    (System.Net.HttpStatusCode.NotFound,
                       en:"Cart Not Found",
                       ar:"عربه التسوق غير موجوده"
                    );
            }
            var cartresp = new CartRes
            {
                CartId = cart.Id,
                UserId = userId,
                CartItems = cart.ProductCarts.Select(ci => new CartItemRes
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product?.Name ?? "",
                    ProductMediaUrl = ci.Product?.MediaUrl ?? "",
                    ProductPrice = ci.Product?.Price ?? 0,
                    Quantity = ci.Quantity
                }).ToList()
            };
            return ApiResponse<CartRes>.SuccessResponse
                (   cartresp,
                    HttpStatusCode.OK,
                    en: "Cart fetched successfully.",
                    ar: "تم جلب عربة التسوق بنجاح."
                );
           
        }
    }
}
