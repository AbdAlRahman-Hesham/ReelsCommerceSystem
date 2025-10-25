using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Cart
{
    public class CartRes
    {
        public int CartId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public List<CartItemRes> CartItems { get; set; } = new();
    }
}
