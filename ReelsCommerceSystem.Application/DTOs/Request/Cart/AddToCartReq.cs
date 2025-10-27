using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Cart
{
    public class AddToCartReq
    {
        public List<CartItemReq> Items { get; set; } = new();
    }

    public class CartItemReq
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
