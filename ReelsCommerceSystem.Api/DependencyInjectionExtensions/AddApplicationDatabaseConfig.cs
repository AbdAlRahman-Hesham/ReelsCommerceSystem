using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using Serilog;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddApplicationDatabaseConfig
{
    public static IServiceCollection AddApplicationDBConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

        Log.Information("╔══════════════════════════════════════════════════╗");
        Log.Information("║Configuring database for environment: {Environment}", envName);
        Log.Information("╚══════════════════════════════════════════════════╝");

        var connString = string.Empty;

        switch (envName)
        {
            case "Development":
                connString = configuration.GetConnectionString("DevelopmentDB");
                break;

            case "Production":
                connString = configuration.GetConnectionString("ProductionDB");
                break;

            case "Staging":
                connString = configuration.GetConnectionString("StagingDB");
                break;

            default:
                break;
        }

        
        if (string.IsNullOrEmpty(connString))
        {
            Log.Error("Connection string is not configured for the current environment: {Environment}", envName);
            throw new InvalidOperationException("Connection string is not configured for the current environment.");
        }

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connString);
        });

        services.AddIdentity<User, IdentityRole>(options =>
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