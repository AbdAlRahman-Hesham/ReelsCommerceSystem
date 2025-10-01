using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddApplicationDatabaseConfig
{
    public static IServiceCollection AddApplicationDBConfig(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
    {
        var devName =env.IsDevelopment()? Environment.GetEnvironmentVariable("DeveloperName"):"OnlineDB";
        var connString = configuration.GetConnectionString(devName!);

        // Add a separator line
        Console.WriteLine(new string('=', 100));

        // Print greeting with only the name in green
        Console.Write("                    Hi ");
        Console.Write(devName);
        Console.WriteLine(" Welcome to the project!");

        // Add another separator line
        Console.WriteLine(new string('=', 100));

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connString);
            //options.UseLazyLoadingProxies(); // enable lazy loading
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