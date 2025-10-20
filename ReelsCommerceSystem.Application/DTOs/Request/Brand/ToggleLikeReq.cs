using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Brand
{
    public class ToggleLikeReq
    {
        public int ReviewId { get; set; }
        public bool IsLiked { get; set; }
    }
}
