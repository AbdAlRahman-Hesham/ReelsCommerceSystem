using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Payment
{
    public class CreatePaymentReqDto
    {
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
