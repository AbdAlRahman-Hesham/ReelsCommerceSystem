using System.Net;
using System.Text.Json;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Api.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;
    private readonly IHostEnvironment _environment;

    public ExceptionHandlingMiddleware(
        RequestDelegate next,
        ILogger<ExceptionHandlingMiddleware> logger,
        IHostEnvironment environment)
    {
        _next = next;
        _logger = logger;
        _environment = environment;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An unhandled exception occurred: {Message}", ex.Message);
            await HandleExceptionAsync(context, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        ApiResponse<object> response;


        switch (exception)
        {
            case UserNotFoundException notFoundEx:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                response = ApiResponse<object>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    notFoundEx.Message,
                    "المستخدم غير موجود"
                );
                break;

            case NotFoundException notFoundEx:
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                response = ApiResponse<object>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    notFoundEx.Message,
                    "العنصر غير موجود"
                );
                break;

            case UnauthorizedException unauthorizedEx:
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                response = ApiResponse<object>.ErrorResponse(
                    HttpStatusCode.Unauthorized,
                    unauthorizedEx.Message,
                    "غير مصرح بالدخول"
                );
                break;

            case BadRequestException badReqEx:
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                response = ApiResponse<object>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    badReqEx.Message,
                    "طلب غير صحيح",
                    badReqEx.Errors
                );
                break;

            default:
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                response = _environment.IsDevelopment()
                    ? CreateDevelopmentErrorResponse(exception)
                    : CreateProductionErrorResponse();
                break;
        }


        var jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = _environment.IsDevelopment() // Pretty print in development
        };

        var jsonResponse = JsonSerializer.Serialize(response, jsonOptions);
        await context.Response.WriteAsync(jsonResponse);
    }

    private static ApiResponse<object> CreateDevelopmentErrorResponse(Exception exception)
    {
        return new ApiResponse<object>
        {
            Success = false,
            StatusCode = (int)HttpStatusCode.InternalServerError,
            Message = new Message
            {
                En = exception.Message,
                Ar = "حدث خطأ أثناء التطوير"
            },
            Data = new
            {
                ExceptionType = exception.GetType().Name,
                Message = exception.Message,
                StackTrace = exception.StackTrace,
                InnerException = exception.InnerException?.Message,
                InnerExceptionStackTrace = exception.InnerException?.StackTrace,
                Source = exception.Source,
                HelpLink = exception.HelpLink,
                Data = exception.Data.Count > 0 ? exception.Data : null
            },
            Errors = null
        };
    }

    private static ApiResponse<object> CreateProductionErrorResponse()
    {
        return ApiResponse<object>.ErrorResponse(
            HttpStatusCode.InternalServerError,
            "An internal server error occurred. Please try again later.",
            "حدث خطأ داخلي في الخادم. يرجى المحاولة مرة أخرى لاحقاً."
        );
    }
}