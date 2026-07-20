using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class CreateBrandRes
    {
        public int Id { get; set; }
        public string DisplayName { get; set; } 
        public string Description { get; set; } 
        public string LogoUrl { get; set; } 
        public string Status { get; set; }
        public string CurrentStep { get; set; } 
    }
}
