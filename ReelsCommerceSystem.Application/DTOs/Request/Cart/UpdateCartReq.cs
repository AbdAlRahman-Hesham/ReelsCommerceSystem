using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Cart
{
    public class UpdateCartReq
    {
        public List<UpdateCartItemReq> Items { get; set; } = new();
    }

    public class UpdateCartItemReq
    {
        public int ProductId { get; set; }

        public int? Quantity { get; set; }

        public int? Change { get; set; }
    }
}
