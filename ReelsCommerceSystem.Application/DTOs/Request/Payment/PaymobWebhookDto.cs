using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Payment
{
    public class PaymobWebhookDto
    {
        public int OrderId { get; set; }        
        public string PaymentStatus { get; set; }
    }
}
