using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class GetMyBrandRes
    {
        public int Id { get; set; }
        public string DisplayName { get; set; } 
        public string Description { get; set; } 
        public string LogoUrl { get; set; } 

        public string Category { get; set; } 
        public string Country { get; set; } 
        public string Governorate { get; set; } 
        public string District { get; set; } 
        public int NumberOfEmployees { get; set; }

        public string Status { get; set; }
        public string CurrentStep { get; set; } 
    }
}
