using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Infrastructure.BackgroundServices;
using ReelsCommerceSystem.Infrastructure.Repositories;
using ReelsCommerceSystem.Infrastructure.Repositories.Finance;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Infrastructure.Services.Finance;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions
{
    public static class RegisterRepositoriesAndServicesExtention
    {
        public static IServiceCollection AddRepositoriesAndServices(this IServiceCollection services)
        {
            // Scoped
            RegisterAllServices(services); 

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IDiscountCodeRepository, DiscountCodeRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IFinanceService, FinanceService>();
            services.AddScoped<IBrandSettlementRepository, BrandSettlementRepository>();
            services.AddScoped<IShippingSettlementRepository, ShippingSettlementRepository>();
            services.AddScoped<IWithdrawalRequestRepository, WithdrawalRequestRepository>();
            services.AddScoped<IFinancialAuditLogRepository, FinancialAuditLogRepository>();

            services.AddHostedService<PayoutStatusProcessor>();


            // Transient


            // Singleton


            return services;
        }

        private static void RegisterAllServices(IServiceCollection services)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.FullName != null && a.FullName.StartsWith("ReelsCommerceSystem"))
                .ToList();

            var excludedServices = new HashSet<string>
            {
                "RecommendationService",
                "PaymobService",
                "GeminiTranslationService"
            };

            foreach (var assembly in assemblies)
            {
                var serviceTypes = assembly.GetTypes()
                    .Where(t =>
                        t.IsClass &&
                        !t.IsAbstract &&
                        t.Name.EndsWith("Service") &&
                        t.Namespace != null &&
                        t.Namespace.StartsWith("ReelsCommerceSystem"))
                    .ToList();

                foreach (var implType in serviceTypes)
                {
                    if (excludedServices.Contains(implType.Name))
                        continue;

                    var interfaceType = implType.GetInterface("I" + implType.Name);
                    if (interfaceType != null)
                        services.AddScoped(interfaceType, implType);
                }
            }
        }


    }
}
