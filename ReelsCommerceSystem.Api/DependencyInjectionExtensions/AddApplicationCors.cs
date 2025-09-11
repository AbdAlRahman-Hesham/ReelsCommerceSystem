namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddApplicationCors
{
    public static IServiceCollection AddApplicationCorsConfig(this IServiceCollection services, IConfiguration configuration)
    {
        // read from appsettings.json
        var allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>();

        // Add CORS service
        services.AddCors(options =>
        {
            options.AddPolicy("AppCorsPolicy", policy =>
            {
                if (allowedOrigins != null && allowedOrigins.Length > 0 && !allowedOrigins.Contains("*"))
                {
                    policy.WithOrigins(allowedOrigins)
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                }
                else
                {
                    // fallback if "*" is in config
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                }
            });
        });
        return services;
    }
}
