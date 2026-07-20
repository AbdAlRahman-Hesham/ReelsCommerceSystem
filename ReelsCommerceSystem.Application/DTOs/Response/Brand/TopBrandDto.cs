using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class TopBrandDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public int TotalViews { get; set; }
    }
}
