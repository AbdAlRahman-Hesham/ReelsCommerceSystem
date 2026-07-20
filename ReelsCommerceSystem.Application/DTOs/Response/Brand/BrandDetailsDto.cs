using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandDetailsDto
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
    }
}
