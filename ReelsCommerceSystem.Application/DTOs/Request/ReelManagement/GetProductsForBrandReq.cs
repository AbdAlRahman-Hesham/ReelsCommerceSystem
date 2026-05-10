using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.ReelManagement
{
    public class GetProductsForBrandReq
    {
        public string StockStatus { get; set; } = "all";
        public string? Search { get; set; }
        public bool SortByPrice { get; set; } = false;
        public bool SortByRating { get; set; } = false;
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 4;
        public List<int> SelectedProductIds { get; set; } = new();

    }
}
