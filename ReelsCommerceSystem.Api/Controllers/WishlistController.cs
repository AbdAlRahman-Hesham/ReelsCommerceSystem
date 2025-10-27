using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Response.Wishlist;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Security.Claims;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class WishlistController:AppBaseController
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpPost("{productId:int}/toggle-love")]
        [Authorize]
        public async Task<IActionResult> ToggleWishlist(int productId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            try
            {
                var result = await _wishlistService.ToggleProductWishlistAsync(userId,productId);

                return Ok(ApiResponse<WishlistToggleRes>.SuccessResponse(
                    result,
                    HttpStatusCode.OK,
                    result.IsLoved ? "Product added to wishlist." : "Product removed from wishlist.",
                    result.IsLoved ? "تمت إضافة المنتج إلى المفضلة." : "تمت إزالة المنتج من المفضلة."
                ));
            }
            catch (KeyNotFoundException)
            {
                return NotFound(ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Product not found.",
                    "المنتج غير موجود."
                ));
            }
            catch (Exception)
            {
                return StatusCode(500, ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "An error occurred while updating wishlist.",
                    "حدث خطأ أثناء تحديث المفضلة."
                ));
            }
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetWishlist()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            var result = await _wishlistService.GetWishlistProductsAsync(userId);
            var messageEn = result.IsEmpty
                ? "Wishlist is empty."
                : "Wishlist retrieved successfully.";

            var messageAr = result.IsEmpty
                ? "قائمة المفضلة فارغة."
                : "تم جلب قائمة المفضلة بنجاح.";

            return Ok(ApiResponse<GetWishlistProductsRes>.SuccessResponse(
                result,
                HttpStatusCode.OK,
                messageEn,
                messageAr
            ));
        }
    }
}
