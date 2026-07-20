using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.ReelManagement
{
    public class CreateReelReq
    {
        public string Title { get; set; } = string.Empty;

        public IFormFile Video { get; set; } = null!;

        public string? Status { get; set; } = ReelStatus.Draft.ToString().ToLower();
        public string? ProductIds { get; set; }
    }
}
