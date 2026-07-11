using ReelsCommerceSystem.Application.DTOs.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelManagement
{
    public class ReelInBrandReelsRes
    {
        public int Id { get; set; }
        public string OwnerName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int LikesCount { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public int SharesCount { get; set; }
        public int ProductsCount { get; set; }
        public List<ProductInReelRes> Products { get; set; } = new List<ProductInReelRes>();

        public DateTime CreatedAt { get; set; }
        public string Thumbnail { get; set; } = string.Empty;
    }
}
