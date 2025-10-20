using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandFollowResponse
    {
        public int BrandId { get; set; }
        public string BrandDisplayName { get; set; } = string.Empty;
        public string BrandLogoUrl { get; set; } = string.Empty;
        public bool IsFollowed { get; set; } 
        public int TotalFollowers { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
