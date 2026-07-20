using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Brand
{
    public class BrandInfoRes
    {
        public string DisplayName { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public int FollowersCount { get; set; }
        public int TotalReelLikes { get; set; }
        public bool IsFollowing { get; set; }

    }
}
