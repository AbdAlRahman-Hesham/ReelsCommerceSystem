using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Dto
{
    public class TranslateRequest
    {
        [Required]
        public string Text { get; set; } = null!;

        [Required]
        public string FromLanguage { get; set; } = null!;

        [Required]
        public string ToLanguage { get; set; } = null!;
    }
}
