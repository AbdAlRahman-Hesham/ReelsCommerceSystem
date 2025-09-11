using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Api.Endpoints;
using ReelsCommerceSystem.Infrastructure.Persistence;

namespace ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;

public static class AppMiddlewareExtentions
{
    public static IApplicationBuilder AddAppMiddleware(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwaggerUI(op =>
            op.SwaggerEndpoint("/openapi/v1.json", "ReelsCommerceSystem"));
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

        app.MapWelcomeEndpoint();

        return app;
    }
}
