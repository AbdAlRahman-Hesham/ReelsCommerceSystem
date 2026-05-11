using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Community
{
    public class CommunityPostsCountsRes
    {
        public int All { get; set; }
        public int Published { get; set; }
        public int Draft { get; set; }
    }
}
