using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Reel
{
    public class ReelViewReq
    {
        public int ReelId { get; set; }
        public int WatchedDurationSeconds { get; set; }
        public int VideoDurationSeconds { get; set; }
    }
}
