using Serilog;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddSerilogExtension
{
    public static IHostBuilder AddSerilog(this IHostBuilder host, IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .CreateLogger();

        return host.UseSerilog();
    }
}
