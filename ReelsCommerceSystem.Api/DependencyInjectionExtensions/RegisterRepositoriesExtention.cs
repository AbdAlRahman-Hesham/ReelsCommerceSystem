using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Infrastructure.Repositories;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Infrastructure.Extensions
{
    public static class RegisterRepositoriesAndServicesExtention
    {
        public static IServiceCollection AddRepositoriesAndServices(this IServiceCollection services)
        {
            // Scoped
            RegisterAllServices(services); 

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUserImageService>(provider =>
            {
                var env = provider.GetRequiredService<IWebHostEnvironment>();
                return new UserImageService(env.WebRootPath);
            });

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();



            // Transient


            // Singleton


            return services;
        }

        private static void RegisterAllServices(IServiceCollection services)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.FullName != null && a.FullName.StartsWith("ReelsCommerceSystem"))
                .ToList();

            foreach (var assembly in assemblies)
            {
                var serviceTypes = assembly.GetTypes()
                    .Where(t =>
                        t.IsClass &&
                        !t.IsAbstract &&
                        t.Name.EndsWith("Service") &&
                        t.Namespace != null &&
                        t.Namespace.StartsWith("ReelsCommerceSystem") &&
                        t.Name != nameof(UserImageService))
                    .ToList();

                foreach (var implType in serviceTypes)
                {
                    var interfaceType = implType.GetInterface("I" + implType.Name);
                    if (interfaceType != null)
                        services.AddScoped(interfaceType, implType);
                }
            }
        }


    }
}