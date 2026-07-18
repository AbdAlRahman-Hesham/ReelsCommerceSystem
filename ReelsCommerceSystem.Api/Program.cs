using Microsoft.AspNetCore.Http.Features;
using ReelsCommerceSystem.Api.BackgroundServices;
using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Api.SignalR.Hubs;
using ReelsCommerceSystem.Api.SignalR.Senders;
using ReelsCommerceSystem.Application.Interfaces.Senders;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Infrastructure.Services.Finance;
using ReelsCommerceSystem.Shared.Utilities;
using Serilog;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to allow larger request bodies for video uploads
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = 1073741824; // 1GB
});

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();
builder.Services.AddScoped<IPhotoServive, PhotoService>();
builder.Services.AddHttpClient<ITranslationService, GeminiTranslationService>();
builder.Services.AddScoped<IChatSender, ChatSender>();
builder.Services.AddHttpClient<IPayoutProvider, PaymobPayoutProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApiConfig();

builder.Services.AddCloudinary(builder.Configuration);
var test = builder.Configuration
    .GetSection("CloudinarySettings")
    .Get<CloudinarySettings>();

builder.Services.AddScoped<ICloudinaryService, CloudinaryService>();

//Console.WriteLine("CONFIG TEST = " + test?.CloudName);

builder.Services.AddHttpClient<IPaymobService, PaymobService>();

builder.Services.AddHttpClient<IRecommendationService, RecommendationService>(
    (sp, client) =>
    {
        var config = sp.GetRequiredService<IConfiguration>();

        var baseUrl = config["RecommendationSettings:BaseUrl"];
        var timeoutSeconds = config.GetValue<int>("RecommendationSettings:TimeoutSeconds", 30);

        client.BaseAddress = new Uri(baseUrl!);
        client.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
    });

builder.Host.AddSerilog(builder.Configuration); 


builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    });

builder.Services.AddSignalR();
builder.Services.AddScoped<INotificationRealtimeSender, NotificationRealtimeSender>();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAppAuthenticationServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient();

builder.Services.AddMemoryCache();
builder.Services.AddHostedService<RecommendationSeedService>();
builder.Services.AddHealthChecks()
    .AddCheck("self", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy(), ["live"])
    .AddDbContextCheck<ReelsCommerceSystem.Infrastructure.Persistence.AppDbContext>(name: "database", tags: ["ready"]);
builder.Services.AddScoped<TestRoomService>();
builder.Services.Configure<FormOptions>(options =>
{
    // Raise this to stop the "1024 exceeded" error
    options.ValueCountLimit = 4096;

    // Crucial for Videos: allow large files (e.g., 1GB)
    options.MultipartBodyLengthLimit = 1073741824;
});

var app = builder.Build();

app.Logger.LogInformation("Application startup initiated. Kestrel will begin listening immediately.");

app.UseSerilogRequestLogging();

app.UseExceptionHandlingMiddleware();

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("AppCorsPolicy");

app.MapControllers();

app.MapHub<NotificationHub>("/notificationHub");
app.MapHub<ChatHub>("/chatHub");

app.AddAppMiddleware();

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

var urls = app.Urls.Any() ? string.Join(", ", app.Urls) : "http://+:8080 (default)";
app.Logger.LogInformation("Server listening on: {Urls}", urls);
app.Logger.LogInformation("Application startup complete. Ready to serve requests.");

app.Run();