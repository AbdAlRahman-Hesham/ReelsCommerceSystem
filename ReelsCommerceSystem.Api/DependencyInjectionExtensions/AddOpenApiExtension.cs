namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddOpenApiExtension
{
    public static IServiceCollection AddOpenApiConfig(this IServiceCollection services)
    {
        return services.AddOpenApi(options =>
        {
            options.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                
                var baseUrl = Environment.GetEnvironmentVariable("BaseUrl");
                if (!string.IsNullOrEmpty(baseUrl))
                {
                    document.Servers = new List<Microsoft.OpenApi.Models.OpenApiServer>
                    {
                        new Microsoft.OpenApi.Models.OpenApiServer { Url = baseUrl },
                        new Microsoft.OpenApi.Models.OpenApiServer { Url = $"http://localhost:8000" }
                    };
                }
                return Task.CompletedTask;
            });
            options.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                document.Info = new()
                {
                    Title = "ReelsCommerceSystem.Api",
                    Version = "v1"
                };

                // Add Bearer token security definition
                document.Components ??= new();
                document.Components.SecuritySchemes["Bearer"] = new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Name = "Authorization",
                    Description = "Enter 'Bearer' followed by a space and your JWT token.\nExample: Bearer eyJhbGciOiJIUzI1NiIs...",
                };

                // Require the Bearer token globally
                document.SecurityRequirements.Add(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
        {
            {
                new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Reference = new Microsoft.OpenApi.Models.OpenApiReference
                    {
                        Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });

                return Task.CompletedTask;
            });
            options.AddSchemaTransformer((schema, context, cancellationToken) =>
            {
                const string annoyingRegex = "^(desc|asc)$";

                if (schema.Properties != null)
                {
                    foreach (var property in schema.Properties.Values)
                    {
                        if (property.Pattern == annoyingRegex)
                        {
                            property.Pattern = null;
                            property.MinLength = 0;
                        }
                    }
                }
                if (schema.Pattern == annoyingRegex)
                {
                    schema.Pattern = null;
                    schema.MinLength = 0;
                }

                return Task.CompletedTask;
            });
        }); 
    }
}
