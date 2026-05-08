using CloudinaryDotNet;
using Microsoft.Extensions.Options;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddCloudinaryExtension
{
    public static IServiceCollection AddCloudinary(this IServiceCollection services, IConfiguration configuration)
    {
        //Console.WriteLine("🔥 CLOUDINARY EXTENSION IS CALLED");
        services.Configure<CloudinarySettings>(
        configuration.GetSection("CloudinarySettings"));

        services.AddSingleton(provider =>
        {
            var settings = provider.GetRequiredService<IOptions<CloudinarySettings>>().Value;
            //Console.WriteLine("CloudName: " + settings.CloudName);
            var account = new Account(settings.CloudName, settings.ApiKey, settings.ApiSecret);
            return new Cloudinary(account);
        });
        return services;
    }
}
