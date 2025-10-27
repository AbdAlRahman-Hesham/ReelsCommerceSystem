using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Wishlist
{
    public class WishlistToggleRes
    {
        public int ProductId { get; set; }
        public bool IsLoved { get; set; }
    }
}
