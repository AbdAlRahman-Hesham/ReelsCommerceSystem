using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Response.Identity
{
    public class RegisterResDto
    {
        public string FirstName { get; set; } = default!;      
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string? ProfileImagePath { get; set; } = default!;
        public string Token { get; set; } = default!;
    }
}
