using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Payment
{
    public class WalletPaymentReq
    {
        public int OrderId { get; set; }        
        public string Phone { get; set; }       
        public string Mpin { get; set; }        
        public string Otp { get; set; }
    }
}
