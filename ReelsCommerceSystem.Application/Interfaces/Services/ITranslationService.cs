using ReelsCommerceSystem.Application.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ITranslationService
    {
        Task<TranslateResponse> TranslateAsync(
         string text,
         string fromLanguage,
         string toLanguage);
    }
}
