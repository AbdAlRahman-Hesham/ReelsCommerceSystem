using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Infrastructure.Persistence;

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
public static class AddApplicationDatabaseConfig
{
    public static IServiceCollection AddApplicationDBConfig(this IServiceCollection services, IConfiguration configuration)
    {
        string user = configuration["DevelperName"]!;
        var connString = configuration.GetConnectionString(user);

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connString);
            options.UseLazyLoadingProxies(); // enable lazy loading
        });

        // Add Identity and configure EF store
        services.AddIdentity<IdentityUser, IdentityRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequiredLength = 6;
        })
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }
}
