using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ReelSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Api.BackgroundServices;

public class RecommendationSeedService : BackgroundService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly IConfiguration _configuration;
    private readonly ILogger<RecommendationSeedService> _logger;

    public RecommendationSeedService(
        IServiceScopeFactory scopeFactory,
        IConfiguration configuration,
        ILogger<RecommendationSeedService> logger)
    {
        _scopeFactory = scopeFactory;
        _configuration = configuration;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Background seeding service started.");

        await ApplyMigrationsAsync(stoppingToken);

        await SeedRecommendationSystemAsync(stoppingToken);

        _logger.LogInformation("Background seeding service completed.");
    }

    private async Task ApplyMigrationsAsync(CancellationToken stoppingToken)
    {
        try
        {
            _logger.LogInformation("Applying pending EF Core database migrations...");

            await using (var scope = _scopeFactory.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                await dbContext.Database.MigrateAsync(stoppingToken);
            }

            _logger.LogInformation("Database migrations applied successfully.");
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("Database migration was cancelled due to application shutdown.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while applying database migrations.");
        }
    }

    private async Task SeedRecommendationSystemAsync(CancellationToken stoppingToken)
    {
        var initialSeedFlag = _configuration["InitialSeedRecomendationSysten"];
        if (!initialSeedFlag?.Equals("true", StringComparison.OrdinalIgnoreCase) == true)
        {
            _logger.LogInformation("InitialSeedRecomendationSysten flag is not set to true. Skipping recommendation seeding.");
            return;
        }

        try
        {
            _logger.LogInformation("InitialSeedRecomendationSysten flag is true. Starting to seed reels into recommendation system...");

            await using (var scope = _scopeFactory.CreateAsyncScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                var recommendationService = scope.ServiceProvider.GetRequiredService<IRecommendationService>();

                var spec = new ReelFeedSpec();
                var reels = await unitOfWork.Repository<Reel>().GetAllWithSpecAsync(spec);

                _logger.LogInformation("Found {Count} reels to seed into recommendation system.", reels.Count);

                foreach (var reel in reels)
                {
                    stoppingToken.ThrowIfCancellationRequested();
                    await recommendationService.ProcessReelAsync(reel);
                }

                _logger.LogInformation("Successfully seeded {Count} reels into recommendation system.", reels.Count);
            }
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("Recommendation seeding was cancelled due to application shutdown.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding reels into recommendation system.");
        }
    }
}
