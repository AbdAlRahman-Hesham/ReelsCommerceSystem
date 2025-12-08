using ReelsCommerceSystem.Application.DTOs.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Reel
{
    public class ReelFeedRes
    {
        public int ReelId { get; set; }
        public string VideoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumOfLikes { get; set; }
        public int NumOfWatches { get; set; }
        public int NumOfComments { get; set; } 

        public string BrandName { get; set; }
        public List<ReelProductRes> Products { get; set; }
    }
}
