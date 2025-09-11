using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Infrastructure.Repositories;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class RegisterRepositoriesAndServicesExtention
{
    public static IServiceCollection AddRepositoriesAndServices(this IServiceCollection services)
    {
        // Scoped
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        
        // Transient


        // Singleton
        
        
        
        return services;
    }
}
