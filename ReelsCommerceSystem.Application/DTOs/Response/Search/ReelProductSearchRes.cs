using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Search
{
    public class ReelProductSearchRes
    {
        public PaginationResponse<ReelSearchRes> Reels { get; set; }
        public PaginationResponse<ProductSearchRes> Products { get; set; }
    }
}
