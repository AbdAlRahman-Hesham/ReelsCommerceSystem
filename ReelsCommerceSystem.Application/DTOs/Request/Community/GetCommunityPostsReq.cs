using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Community
{
    public class GetCommunityPostsReq
    {
        public string Status { get; set; } = "all";
        public string? Search { get; set; }
        public string Sort { get; set; } = "latest";
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 12;
    }
}
