using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Product
{
    public class ProductInformationReq
    {
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;

        public string? ArKey { get; set; }
        public string? ArValue { get; set; }

        public InformationType Type { get; set; }

        public string? Group { get; set; }
        public string? ArGroup { get; set; }

        public int DisplayOrder { get; set; }
    }
}
