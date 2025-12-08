using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Search
{
    public class ReelSearchRes
    {
        public int ReelId { get; set; }
        public string Title { get; set; }
        public int NumOfWatches { get; set; }
        public int NumOfLikes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string VideoUrl { get; set; } = null!;
    }
}
