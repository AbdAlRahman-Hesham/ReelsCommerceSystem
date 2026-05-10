using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.ReelManagement
{
    public class GetReelAnalyticsRes
    {
        public decimal GrowthPercentage { get; set; }

        public int CurrentMonthViews { get; set; }

        public int LastMonthViews { get; set; }

        public List<int> Years { get; set; } = [];

        public List<MonthlyViewsRes> MonthlyViews { get; set; } = [];
    }

    public class MonthlyViewsRes
    {
        public string Month { get; set; } = null!;

        public int Views { get; set; }

    }
}
