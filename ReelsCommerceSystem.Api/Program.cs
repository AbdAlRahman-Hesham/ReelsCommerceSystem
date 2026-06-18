using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Http.Features;
using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;
using ReelsCommerceSystem.Api.SignalR.Hubs;
using ReelsCommerceSystem.Api.SignalR.Senders;
using ReelsCommerceSystem.Application.Interfaces.Senders;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Services;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Utilities;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to allow larger request bodies for video uploads
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = 209715200; // 200MB
});

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();
builder.Services.AddScoped<IPhotoServive, PhotoService>();
builder.Services.AddHttpClient<ITranslationService, GeminiTranslationService>();
builder.Services.AddScoped<IChatSender, ChatSender>();  

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

        client.BaseAddress = new Uri(baseUrl!);
        client.Timeout = TimeSpan.FromSeconds(10);
    });

builder.Host.AddSerilog(builder.Configuration); 


builder.Services.AddApplicationCorsConfig(builder.Configuration);

builder.Services.AddApplicationDBConfig(builder.Configuration);
    
builder.Services.AddRepositoriesAndServices();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSignalR();
builder.Services.AddScoped<INotificationRealtimeSender, NotificationRealtimeSender>();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddAppAuthenticationServices(builder.Configuration);

builder.Services.AddHttpContextAccessor();

builder.Services.AddHttpClient();

builder.Services.AddMemoryCache();
builder.Services.AddHealthChecks()
    .AddCheck("self", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy(), ["live"])
    .AddDbContextCheck<ReelsCommerceSystem.Infrastructure.Persistence.AppDbContext>(name: "database", tags: ["ready"]);
builder.Services.AddScoped<TestRoomService>();
builder.Services.Configure<FormOptions>(options =>
{
    // Raise this to stop the "1024 exceeded" error
    options.ValueCountLimit = 4096;

    // Crucial for Videos: allow large files (e.g., 200MB)
    options.MultipartBodyLengthLimit = 209715200;
});

var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseExceptionHandlingMiddleware();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("AllowDevTunnel");

app.MapControllers();

app.MapHub<NotificationHub>("/notificationHub");
app.MapHub<ChatHub>("/chatHub");

app.AddAppMiddleware();


//await using (var scope = app.Services.CreateAsyncScope())
//{
//    var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

//    var brands = await unitOfWork.Repository<Brand>()
//        .GetAllWithSpecAsync(new BrandWithReviewSpec());

//    foreach (var brand in brands)
//    {
//        var reviews = brand.Reviews ?? new List<BrandReview>();

//        brand.NumOfReviews = reviews.Count;
//        brand.AverageRating = reviews.Any() ? reviews.Average(r => r.Rating) : 0;

//        unitOfWork.Repository<Brand>().Update(brand);
//    }

//    await unitOfWork.SaveChangesAsync();
//}

var initialSeedFlag = builder.Configuration["InitialSeedRecomendationSysten"];
if (initialSeedFlag?.Equals("true", StringComparison.OrdinalIgnoreCase) == true)
{
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("InitialSeedRecomendationSysten flag is true. Starting to seed reels into recommendation system...");

    using (var scope = app.Services.CreateScope())
    {
        var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
        var recommendationService = scope.ServiceProvider.GetRequiredService<IRecommendationService>();

        var spec = new ReelFeedSpec();
        var reels = await unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

        logger.LogInformation("Found {Count} reels to seed into recommendation system.", reels.Count);

        foreach (var reel in reels)
        {
            await recommendationService.ProcessReelAsync(reel);
        }

        logger.LogInformation("Successfully seeded {Count} reels into recommendation system.", reels.Count);
    }

    try
    {
        var appSettingsPath = Path.Combine(builder.Environment.ContentRootPath, "appsettings.json");
        if (File.Exists(appSettingsPath))
        {
            var json = File.ReadAllText(appSettingsPath);
            var jsonNode = JsonNode.Parse(json);
            if (jsonNode is JsonObject rootObj)
            {
                rootObj["InitialSeedRecomendationSysten"] = JsonValue.Create(false);
                var writeOptions = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(appSettingsPath, rootObj.ToJsonString(writeOptions));
                logger.LogInformation("Set InitialSeedRecomendationSysten flag to false in appsettings.json.");
            }
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Failed to update InitialSeedRecomendationSysten flag in appsettings.json.");
    }
}

app.Run();