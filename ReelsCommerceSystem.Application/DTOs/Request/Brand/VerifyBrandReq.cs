using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Brand
{
    public class VerifyBrandReq
    {
        public string FullName { get; set; } = null!;
        public string NationalId { get; set; } = null!;
        public string? TaxNumber { get; set; }
        public string PhoneNumber { get; set; } = null!;

        public IFormFile IdFrontImage { get; set; } = null!;
        public IFormFile IdBackImage { get; set; } = null!;
        public IFormFile SelfieImage { get; set; } = null!;
    }
}
