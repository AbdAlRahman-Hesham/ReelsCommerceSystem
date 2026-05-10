using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.ReelManagement
{
    public class EditReelReq
    {
        public int ReelId { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public bool ClearProducts { get; set; } = false;

        public IFormFile? Video { get; set; }

        public string? ProductIds { get; set; }
    }
}
