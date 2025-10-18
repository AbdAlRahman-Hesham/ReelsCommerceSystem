using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandPolicyRes
    {
        public int BrandId { get; set; }
        public string ReturnPolicyAsHtml { get; set; } = null!;
    }
}
