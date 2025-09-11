using Microsoft.AspNetCore.Builder;
namespace ReelsCommerceSystem.Api.Endpoints;


public static class WelcomeEndpoint
{
    public static void MapWelcomeEndpoint(this WebApplication app)
    {
        app.MapGet("/welcome", () => "Welcome! It will be a good project 🙌🥰🥰🥰🥰");
    }
}