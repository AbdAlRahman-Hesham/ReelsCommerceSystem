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

        public List<DailyViewsRes> DailyViews { get; set; } = [];

        public List<YearlyViewsRes> YearlyViews { get; set; } = [];
    }

    public class MonthlyViewsRes
    {
        public string Month { get; set; } = null!;

        public int Views { get; set; }

    }

    public class DailyViewsRes
    {
        public string Date { get; set; } = null!;

        public int Views { get; set; }
    }

    public class YearlyViewsRes
    {
        public int Year { get; set; }

        public int Views { get; set; }
    }
}
