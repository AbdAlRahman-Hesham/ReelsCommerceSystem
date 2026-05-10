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
        public async Task<TranslateResponse> TranslateAsync(
         string text,
         string fromLanguage,
         string toLanguage)
        {
            try
            {
                var apiKey = _config["Gemini:ApiKey"];

                var prompt = $@"
                         Translate from {fromLanguage} to {toLanguage}.
                         Return ONLY translated text.

                         Text: {text}";

                var requestBody = new
                {
                    contents = new[]
                    {
                    new
                    {
                        parts = new[]
                        {
                            new
                            {
                                text = prompt
                            }
                        }
                    }
                }
                };

                var url =
                    $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={apiKey}";

                var response =
                    await _httpClient.PostAsJsonAsync(url, requestBody);

                var responseContent =
                    await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new TranslateResponse
                    {
                        Success = false,
                        ErrorMessage = responseContent
                    };
                }

                var result =
                    JsonSerializer.Deserialize<GeminiResponse>(
                        responseContent);

                var translatedText =
                    result?.candidates?
                    .FirstOrDefault()?
                    .content?
                    .parts?
                    .FirstOrDefault()?
                    .text;

                return new TranslateResponse
                {
                    Success = true,
                    TranslatedText = translatedText
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
    }
}