using ReelsCommerceSystem.Application.DTOs.Response.PagedResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelManagement
{
    public class GetBrandReelsRes : PagedResponse<ReelInBrandReelsRes>
    {
        public ReelsCountsRes Counts { get; set; } = new();
    }
}
