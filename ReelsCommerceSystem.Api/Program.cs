using CloudinaryDotNet;
using Microsoft.Extensions.Options;
using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Shared.Utilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApi();

builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration, builder.Environment);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.Configure<CloudinarySettings>(
    builder.Configuration.GetSection("CloudinarySettings"));

builder.Services.AddSingleton(provider =>
{
    var settings = provider.GetRequiredService<IOptions<CloudinarySettings>>().Value;
    var account = new Account(settings.CloudName, settings.ApiKey, settings.ApiSecret);
    return new Cloudinary(account);
});

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