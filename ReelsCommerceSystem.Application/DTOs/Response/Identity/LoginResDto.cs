using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Identity
{
    public class LoginResDto
    {
        public string Token { get; set; } = default!;
        public DateTime ExpiresAt { get; set; }

    }
}
