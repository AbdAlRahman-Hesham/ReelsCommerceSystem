using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Wishlist
{
    public class GetWishlistProductsRes
    {
        public bool IsEmpty { get; set; }
        public int Count { get; set; }
        public List<WishlistProductRes> Products { get; set; } = new();
    }
}
