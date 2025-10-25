using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Cart
{
    public class AddToCartReq
    {
        public string  userId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        
    }
}
