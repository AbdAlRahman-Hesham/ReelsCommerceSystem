using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApi();

builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration, builder.Environment);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAppAuthenticationServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient();


var app = builder.Build();



app.UseExceptionHandlingMiddleware();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.AddAppMiddleware();

app.UseStaticFiles();

app.Run();