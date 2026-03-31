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
        public Brand Brand { get; set; }

        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string TaxNumber { get; set; }

        public string IdFrontImage { get; set; }
        public string IdBackImage { get; set; }
        public string SelfieImage { get; set; }

        public string PhoneNumber { get; set; }
    }
}
