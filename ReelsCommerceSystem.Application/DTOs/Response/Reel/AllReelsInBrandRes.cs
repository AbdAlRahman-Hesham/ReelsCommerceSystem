using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Reel
{
    public class AllReelsInBrandRes
    {
        public int ReelId { get; set; }
        public string ThumbnailUrl { get; set; } = null!;
        public int NumOfWatches { get; set; }
        public int NumOfLikes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string VideoUrl { get; set; } = null!;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductMediaUrl { get; set; } = null!;
        public decimal ProductPrice { get; set; }


    }
}
