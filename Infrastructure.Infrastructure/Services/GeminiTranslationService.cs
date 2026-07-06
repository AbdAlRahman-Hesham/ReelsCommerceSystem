using Microsoft.Extensions.Configuration;
using ReelsCommerceSystem.Application.DTOs.Dto;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class GeminiTranslationService : ITranslationService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public GeminiTranslationService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        private async Task<string> CallGeminiAsync(string prompt)
        {
            var apiKey = _config["Gemini:ApiKey"];
            var url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={apiKey}";

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                }
            };

            var response = await _httpClient.PostAsJsonAsync(url, requestBody);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                return null!;

            var result = JsonSerializer.Deserialize<GeminiResponse>(responseContent);
            return result?.candidates?.FirstOrDefault()?.content?.parts?.FirstOrDefault()?.text;
        }

        public async Task<TranslateResponse> TranslateAsync(
         string text,
         string fromLanguage,
         string toLanguage)
        {
            try
            {
                var prompt = $@"
                         Translate from {fromLanguage} to {toLanguage}.
                         Return ONLY translated text.

                         Text: {text}";

                var responseText = await CallGeminiAsync(prompt);

                if (responseText == null)
                {
                    return new TranslateResponse
                    {
                        Success = false,
                        ErrorMessage = "Translation failed"
                    };
                }

                return new TranslateResponse
                {
                    Success = true,
                    TranslatedText = responseText
                };
            }
            catch (Exception ex)
            {
                return new TranslateResponse
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        public async Task<DetectLanguageResponse> DetectLanguageAsync(string text)
        {
            try
            {
                var prompt = $@"
                         Detect the language of the following text.
                         Reply with exactly 'en' if the text is English,
                         or exactly 'ar' if the text is Arabic.
                         Return ONLY the two-letter code, nothing else.

                         Text: {text}";

                var responseText = await CallGeminiAsync(prompt);

                if (string.IsNullOrWhiteSpace(responseText))
                {
                    return new DetectLanguageResponse
                    {
                        Success = false,
                        ErrorMessage = "Language detection failed"
                    };
                }

                var language = responseText.Trim().ToLowerInvariant();
                if (language != "en" && language != "ar")
                {
                    return new DetectLanguageResponse
                    {
                        Success = false,
                        ErrorMessage = $"Unrecognized language: {language}"
                    };
                }

                return new DetectLanguageResponse
                {
                    Success = true,
                    Language = language
                };
            }
            catch (Exception ex)
            {
                return new DetectLanguageResponse
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };
            }
        }
    }
}