using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Admin
{
    public class AdminLoginReqDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
