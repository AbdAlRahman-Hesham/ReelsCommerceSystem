using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Dto
{
    public class TranslateResponse
    {
        public bool Success { get; set; }

        public string? TranslatedText { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
