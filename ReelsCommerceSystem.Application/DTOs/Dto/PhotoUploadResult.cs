using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Dto
{
    public class PhotoUploadResult
    {
        public string Url { get; set; } = null!;
        public string PublicId { get; set; } = null!;
    }
}
