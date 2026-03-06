using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ReelsCommerceSystem.Api.Endpoints;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;

public static class AppMiddlewareExtentions
{
    public static IApplicationBuilder AddAppMiddleware(this WebApplication app)
    {
        if (/*app.Environment.IsDevelopment()*/ true)
        {
            app.MapOpenApi();

            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swagger, httpReq) =>
                {
                    swagger.Servers = new List<OpenApiServer>
                    {
                        new OpenApiServer { Url = $"{httpReq.Scheme}://{httpReq.Host.Value}" }
                    };
                });
            });

            app.UseSwaggerUI(op =>
            {

                op.DisplayRequestDuration();
                op.SwaggerEndpoint("/openapi/v1.json", "Reels Commerce System Enviroment " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
            }

            );
        }


        // Auto apply migrations on startup
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbContext.Database.Migrate();
        }

        

        app.UseStatusCodePages(async context =>
        {
            if (context.HttpContext.Response.StatusCode == 404)
            {
                context.HttpContext.Response.Redirect("/Api/Error/NotFound");
            }
        });

        app.UseCors("AppCorsPolicy");

        app.MapHealthChecks("/health/live", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
        {
            Predicate = registration => registration.Tags.Contains("live")
        });

        app.MapHealthChecks("/health/ready", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
        {
            Predicate = registration => registration.Tags.Contains("ready")
        });

        app.MapHealthChecks("/health/details", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
        {
            ResponseWriter = HealthChecks.UI.Client.UIResponseWriter.WriteHealthCheckUIResponse
        });

        app.MapWelcomeEndpoint();

        return app;
    }
}
