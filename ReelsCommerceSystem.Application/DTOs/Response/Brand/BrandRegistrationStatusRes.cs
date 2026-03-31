using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandRegistrationStatusRes
    {
        public int CurrentStep { get; set; }
        public string Status { get; set; } 
        public string? RejectionReason { get; set; }
    }
}
