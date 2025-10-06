using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ReelsCommerceSystem.Application.DTOs.Request.Identity
{
    public class RegisterReqDto
    {
        [Required(ErrorMessage = "The First Name field is required.")]
        public string FirstName { get; set; } = default!;
        [Required(ErrorMessage = "The Last Name field is required.")]
        public string LastName { get; set; } = default!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "The Phone Number field is required.")]
        [RegularExpression(@"^\+20(10|11|12|15)\d{8}$",ErrorMessage ="Invalid phone number format.")]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        [MinLength(6)]
        public string Password { get; set; } = default!;
        public DateTime? DateOfBirth { get; set; }
        [RegularExpression("^(Male|Female)$")]
        public string? Gender { get; set; }
        public IFormFile? ProfileImage { get; set; }


    }
}
