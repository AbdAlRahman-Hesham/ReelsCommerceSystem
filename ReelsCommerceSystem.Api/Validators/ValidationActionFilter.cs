using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ReelsCommerceSystem.Shared.Responses;
using System.Net;
using System.Text.Json;

namespace ReelsCommerceSystem.Api.Middlewares;


public class ValidationActionFilter : IActionFilter
{
    private readonly IValidationMessageProvider _provider;

    public ValidationActionFilter(IValidationMessageProvider provider)
    {
        _provider = provider;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = new List<ValidationError>();

            foreach (var modelError in context.ModelState)
            {
                var fieldName = modelError.Key;
                foreach (var error in modelError.Value.Errors)
                {

                    errors.Add(new ValidationError
                    {
                        Field = fieldName,
                        En = error.ErrorMessage,
                        Ar = TranslateErrorToArabic(error.ErrorMessage, fieldName)
                    });
                }

            }

            var response = ApiResponse<object>.ErrorResponse(
                HttpStatusCode.BadRequest,
                "Validation failed",
                _provider.GetMessage("ValidationFailed", "ar"),
                errors
            );

            context.Result = new BadRequestObjectResult(response);
        }
    }

    public void OnActionExecuted(ActionExecutedContext context) { }

    private string TranslateErrorToArabic(string errorKey, params object[] args)
    {
        var template = _provider.GetMessage(errorKey, "ar");
        return string.Format(template, args);
    }
  

}


public class ValidationMessageEntry
{
    public string En { get; set; }
    public string Ar { get; set; }
}

public interface IValidationMessageProvider
{
    string GetMessage(string key, string lang = "ar");
}

public class JsonValidationMessageProvider : IValidationMessageProvider
{
    private readonly List<ValidationMessageEntry> _messages;

    public JsonValidationMessageProvider(IWebHostEnvironment env)
    {
        try
        {
            var filePath = Path.Combine(env.ContentRootPath, "Resources", "ValidationMessageResource.json");
            var json = File.ReadAllText(filePath);
            _messages = JsonSerializer.Deserialize<List<ValidationMessageEntry>>(json)
                        ?? new List<ValidationMessageEntry>();
        }
        catch (Exception ex)
        {
            _messages = new List<ValidationMessageEntry>();
            Console.WriteLine($"Error reading validation messages: {ex.Message}");
        }
    }

    public string GetMessage(string enMsg, string lang = "ar")
    {
        var entry = _messages.FirstOrDefault(x => x.En == enMsg);

        if (entry == null)
            return "No Validation Message Found";

        return lang.ToLower() switch
        {
            "en" => entry.En,
            "ar" => entry.Ar,
            _ => entry.En
        };
        
    }
}
