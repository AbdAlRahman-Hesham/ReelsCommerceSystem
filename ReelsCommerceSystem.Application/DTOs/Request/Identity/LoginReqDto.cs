using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Request.Identity
{
    public class LoginReqDto
    {
        [EmailAddress(ErrorMessage = "Please Enter a valid email address")]
        [Required]
        public string Email { get; set; } = default!;
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; } = default!;
    }
}
