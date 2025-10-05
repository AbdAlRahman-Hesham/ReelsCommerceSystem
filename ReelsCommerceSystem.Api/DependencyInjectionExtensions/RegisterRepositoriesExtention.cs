using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Repositories;
using ReelsCommerceSystem.Infrastructure.Services;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class RegisterRepositoriesAndServicesExtention
{
    public static IServiceCollection AddRepositoriesAndServices(this IServiceCollection services)
    {
        // Scoped
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUserImageService>(provider =>
        {
           
            var env = provider.GetRequiredService<IWebHostEnvironment>();
            return new UserImageService(env.WebRootPath);
        });
       
        services.AddScoped<IAuthenticationService, AuthenticationService>();


        // Transient


        // Singleton



        return services;
    }
}
