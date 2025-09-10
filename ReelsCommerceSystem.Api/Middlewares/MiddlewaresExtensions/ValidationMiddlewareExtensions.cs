using Microsoft.AspNetCore.Mvc;

namespace ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;

public static class ValidationMiddlewareExtensions
{
    public static IServiceCollection AddValidationMiddleware(this IServiceCollection services)
    {
        // Configure ModelState validation behavior
        services.Configure<ApiBehaviorOptions>(options =>
        {
            // Disable default model validation response
            options.SuppressModelStateInvalidFilter = true;
        });

        // Add the validation action filter globally
        services.AddControllers(options =>
        {
            options.Filters.Add<ValidationActionFilter>();
        }).AddDataAnnotationsLocalization();

        return services;
    }
}
