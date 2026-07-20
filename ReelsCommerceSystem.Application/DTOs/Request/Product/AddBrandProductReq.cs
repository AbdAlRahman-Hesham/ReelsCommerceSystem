using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product
{
    public class AddBrandProductReq
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public bool IsCustomizable { get; set; }
        public decimal? DiscountPercentage { get; set; }

        public List<ProductColorReq> Colors { get; set; } = new();
        public List<ProductInformationReq>? Informations { get; set; }
    }
}
