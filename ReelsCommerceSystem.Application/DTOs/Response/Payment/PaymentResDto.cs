using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Payment
{
    public class PaymentResDto
    {
        public string PaymentUrl { get; set; }
        public decimal Amount { get; set; }
        public int OrderId { get; set; }

        public string? PaymobOrderId { get; set; }
    }
}
