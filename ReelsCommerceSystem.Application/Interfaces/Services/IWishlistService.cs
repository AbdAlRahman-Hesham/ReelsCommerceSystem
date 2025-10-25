using ReelsCommerceSystem.Application.DTOs.Response.Wishlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IWishlistService
    {
        Task<WishlistToggleRes> ToggleProductWishlistAsync(string userId, int productId);
        Task<GetWishlistProductsRes> GetWishlistProductsAsync(string userId);

    }
}
