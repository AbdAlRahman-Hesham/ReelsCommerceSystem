using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
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
        var initialSeedFlag = _configuration["InitialSeedRecomendationSysten"];
        if (!initialSeedFlag?.Equals("true", StringComparison.OrdinalIgnoreCase) == true)
        {
            return;
        }

        try
        {
            _logger.LogInformation("InitialSeedRecomendationSysten flag is true. Starting to seed reels into recommendation system...");

            using (var scope = _scopeFactory.CreateScope())
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
