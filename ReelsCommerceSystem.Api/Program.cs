using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Shared.Utilities;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApiConfig();

builder.Services.AddCloudinary(builder.Configuration);

builder.Services.AddHttpClient<IPaymobService, PaymobService>();

builder.Host.AddSerilog(builder.Configuration); 


builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowDevTunnel", policy =>
    {
        policy.WithOrigins("https://6vxv50c7-7146.uks1.devtunnels.ms")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAppAuthenticationServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient();

builder.Services.AddMemoryCache();
builder.Services.AddHealthChecks()
    .AddCheck("self", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy(), ["live"])
    .AddDbContextCheck<ReelsCommerceSystem.Infrastructure.Persistence.AppDbContext>(name: "database", tags: ["ready"]);

var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseExceptionHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("AllowDevTunnel");

app.MapControllers();

app.AddAppMiddleware();

app.UseStaticFiles();

app.Run();