using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Dto;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class TranslationController : AppBaseController 
    {

        private readonly ITranslationService _translationService;

        public TranslationController(ITranslationService translationService)
        {
            _translationService = translationService;
        }
        [HttpPost]
        public async Task<IActionResult> Translate(
        TranslateRequest request)
        {

            if (string.IsNullOrWhiteSpace(request.FromLanguage) ||
               string.IsNullOrWhiteSpace(request.ToLanguage))
            {
                return BadRequest(new
                {
                    success = false,
                    error = "FromLanguage and ToLanguage are required"
                });
            }
                var result = await _translationService.TranslateAsync(
                request.Text,
                request.FromLanguage,
                request.ToLanguage);

            if (!result.Success)
            {
                return BadRequest(new
                {
                    success = false,
                    error = result.ErrorMessage
                });
            }

            return Ok(new
            {
                success = true,
                translatedText = result.TranslatedText
            });
        }
    }
}
