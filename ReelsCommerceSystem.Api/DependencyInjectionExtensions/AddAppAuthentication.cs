using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Responses;
using System.Text;

namespace ReelsCommerceSystem.Api.DependencyInjectionExtensions;

public static class AddAppAuthentication
{
    public static IServiceCollection AddAppAuthenticationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Add authentication services here in the future
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["JWTOptions:Issuer"],
                ValidAudience = configuration["JWTOptions:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWTOptions:SecretKey"]!)
                )
            };

            options.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    var token = context.Request.Headers["Authorization"].FirstOrDefault();
                    if (!string.IsNullOrWhiteSpace(token))
                    {
                        token = token.Replace("Bearer ", "").Trim();
                        context.Token = token;
                        context.HttpContext.Items["RawJwtToken"] = token;
                    }
                    return Task.CompletedTask;
                },

                OnTokenValidated = async context =>
                {
                    var blacklistService = context.HttpContext.RequestServices
                        .GetRequiredService<ITokenBlacklistService>();

                    var token = context.HttpContext.Items["RawJwtToken"] as string;

                    if (!string.IsNullOrEmpty(token))
                    {
                        bool isBlacklisted = await blacklistService.IsBlacklistedAsync(token);
                        if (isBlacklisted)
                        {
                            context.Fail("This token has been revoked. Please sign in again.");
                            return;
                        }
                    }

                    await Task.CompletedTask;
                },

                OnChallenge = context =>
                {
                    context.HandleResponse();

                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    context.Response.ContentType = "application/json";

                    var response = ApiResponse<string>
                        .ErrorResponse(System.Net.HttpStatusCode.Unauthorized,
                        "Unauthorized — please sign in to continue.",
                        "غير مصرح — من فضلك سجّل الدخول عشان تكمل.");

                    var json = System.Text.Json.JsonSerializer.Serialize(response);
                    return context.Response.WriteAsync(json);
                }
            };
        });
        return services;
    }
}
