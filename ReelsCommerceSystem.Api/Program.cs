using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Shared.Utilities;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApiConfig();

builder.Services.AddCloudinary(builder.Configuration);

builder.Host.AddSerilog(builder.Configuration); 


builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration, builder.Environment);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAppAuthenticationServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient();

builder.Services.AddMemoryCache();


var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseExceptionHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.AddAppMiddleware();

app.UseStaticFiles();

app.Run();