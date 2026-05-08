using ReelsCommerceSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Domain.Entities.BrandEntities
{
    public class BrandVerification : BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public string FullName { get; set; } = null!;
        public string NationalId { get; set; } = null!;
        public string? TaxNumber { get; set; }

        public string IdFrontImage { get; set; } = null!;
        public string IdBackImage { get; set; } = null!;
        public string SelfieImage { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
