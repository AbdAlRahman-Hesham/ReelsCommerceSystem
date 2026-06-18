using Microsoft.Extensions.Logging;
using ReelsCommerceSystem.Application.DTOs.Request.Recommendation;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class RecommendationService : IRecommendationService
    {
        private readonly HttpClient _httpClient;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<RecommendationService> _logger;

        public RecommendationService(
            HttpClient httpClient,
            IUnitOfWork unitOfWork,
            ILogger<RecommendationService> logger)
        {
            _httpClient = httpClient;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task ProcessReelAsync(Reel reel)
        {
            try
            {
                var payload = new ReelPayloadDto
                {
                    Id = reel.Id,
                    Title = reel.Title,
                    VideoUrl = reel.VideoUrl,
                    Brand = new BrandPayloadDto
                    {
                        DisplayName = reel.Brand?.DisplayName ?? "Default Brand",
                        Description = reel.Brand?.Description ?? string.Empty
                    },
                    ProductReels = reel.ProductReels?.Select(pr => (object)new { ProductId = pr.ProductId }).ToList() ?? new List<object>(),
                    CreatedAt = reel.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                    NumOfLikes = reel.NumOfLikes,
                    NumOfWatches = reel.NumOfWatches
                };

                var batchPayload = new BatchProcessPayloadDto
                {
                    Reels = new List<ReelPayloadDto> { payload }
                };

                _logger.LogInformation("Sending batch process payload for Reel ID: {ReelId} to recommendation engine.", reel.Id);
                var response = await _httpClient.PostAsJsonAsync("/api/reels/process", batchPayload);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("Failed to process Reel ID: {ReelId} in recommendation engine. StatusCode: {StatusCode}. Response: {Response}",
                        reel.Id, response.StatusCode, errorMsg);
                }
                else
                {
                    _logger.LogInformation("Successfully processed Reel ID: {ReelId} in recommendation engine.", reel.Id);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while processing Reel ID: {ReelId} in recommendation engine.", reel.Id);
            }
        }

        public async Task UpdateReelMetadataAsync(int reelId, int likes, int watches)
        {
            try
            {
                var batchPayload = new BatchUpdatePayloadDto
                {
                    Reels = new List<ReelUpdatePayloadDto>
                    {
                        new ReelUpdatePayloadDto
                        {
                            ReelId = reelId,
                            Likes = likes,
                            Watches = watches
                        }
                    }
                };

                _logger.LogInformation("Sending metadata update for Reel ID: {ReelId} (Likes: {Likes}, Watches: {Watches}) to recommendation engine.", reelId, likes, watches);
                var response = await _httpClient.PutAsJsonAsync("/api/reels/update-metadata", batchPayload);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("Failed to update metadata for Reel ID: {ReelId} in recommendation engine. StatusCode: {StatusCode}. Response: {Response}",
                        reelId, response.StatusCode, errorMsg);
                }
                else
                {
                    _logger.LogInformation("Successfully updated metadata for Reel ID: {ReelId} in recommendation engine.", reelId);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating metadata for Reel ID: {ReelId} in recommendation engine.", reelId);
            }
        }

        public async Task DeleteReelAsync(int reelId)
        {
            try
            {
                _logger.LogInformation("Deleting Reel ID: {ReelId} from recommendation engine.", reelId);
                var response = await _httpClient.DeleteAsync($"/api/reels/delete?reel_id={reelId}");

                if (!response.IsSuccessStatusCode)
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("Failed to delete Reel ID: {ReelId} from recommendation engine. StatusCode: {StatusCode}. Response: {Response}",
                        reelId, response.StatusCode, errorMsg);
                }
                else
                {
                    _logger.LogInformation("Successfully deleted Reel ID: {ReelId} from recommendation engine.", reelId);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting Reel ID: {ReelId} from recommendation engine.", reelId);
            }
        }

        public async Task<List<int>> GetRecommendedReelIdsAsync(string userId, int topK = 10)
        {
            try
            {
                _logger.LogInformation("Fetching recommendations for User ID: {UserId} (Top K: {TopK})", userId, topK);

                var likesSpec = new Specification<UserReelLike>(l => l.UserId == userId);
                var likes = await _unitOfWork.Repository<UserReelLike>().GetAllWithSpecAsync(likesSpec);

                var viewsSpec = new Specification<UserReelView>(v => v.UserId == userId);
                var views = await _unitOfWork.Repository<UserReelView>().GetAllWithSpecAsync(viewsSpec);

                var userPayload = new UserPayloadDto
                {
                    Id = userId,
                    UserReelLikes = likes.Select(l => new UserReelLikePayloadDto { ReelId = l.ReelId }).ToList(),
                    UserReelViews = views.Select(v => new UserReelViewPayloadDto
                    {
                        ReelId = v.ReelId,
                        WatchedDurationSeconds = v.WatchedDurationSeconds,
                        VideoDurationSeconds = v.VideoDurationSeconds
                    }).ToList()
                };

                var response = await _httpClient.PostAsJsonAsync($"/api/users/recommend?top_k={topK}", userPayload);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    _logger.LogWarning("Failed to fetch recommendations for User ID: {UserId}. StatusCode: {StatusCode}. Response: {Response}",
                        userId, response.StatusCode, errorMsg);
                    return new List<int>();
                }

                var jsonContent = await response.Content.ReadAsStringAsync();
                var reelIds = ParseRecommendationIds(jsonContent);

                _logger.LogInformation("Successfully fetched {Count} recommended reel IDs for User ID: {UserId}", reelIds.Count, userId);
                return reelIds;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching recommendations for User ID: {UserId}", userId);
                return new List<int>();
            }
        }

        private List<int> ParseRecommendationIds(string jsonContent)
        {
            var result = new List<int>();

            if (string.IsNullOrWhiteSpace(jsonContent))
                return result;

            using var doc = JsonDocument.Parse(jsonContent);
            var root = doc.RootElement;

            if (root.ValueKind == JsonValueKind.Object)
            {
                if (root.TryGetProperty("recommendedReelIds", out var reelsArray) &&
                    reelsArray.ValueKind == JsonValueKind.Array)
                {
                    ParseJsonArray(reelsArray, result);
                    return result;
                }

                // fallback (generic search)
                string[] potentialKeys =
                {
                    "reels",
                    "recommendations",
                    "data",
                    "items",
                    "results"
                };

                foreach (var key in potentialKeys)
                {
                    if (root.TryGetProperty(key, out var prop) &&
                        prop.ValueKind == JsonValueKind.Array)
                    {
                        ParseJsonArray(prop, result);
                        return result;
                    }
                }

                // last fallback: scan all properties
                foreach (var property in root.EnumerateObject())
                {
                    if (property.Value.ValueKind == JsonValueKind.Array)
                    {
                        ParseJsonArray(property.Value, result);
                        return result;
                    }
                }
            }
            else if (root.ValueKind == JsonValueKind.Array)
            {
                ParseJsonArray(root, result);
            }

            return result;
        }

        private void ParseJsonArray(JsonElement arrayElement, List<int> result)
        {
            foreach (var item in arrayElement.EnumerateArray())
            {
                if (item.ValueKind == JsonValueKind.Number && item.TryGetInt32(out int id))
                {
                    result.Add(id);
                }
                else if (item.ValueKind == JsonValueKind.String && int.TryParse(item.GetString(), out int parsedId))
                {
                    result.Add(parsedId);
                }
                else if (item.ValueKind == JsonValueKind.Object)
                {
                    if (TryExtractReelId(item, out int objId))
                    {
                        result.Add(objId);
                    }
                }
            }
        }


        private bool TryExtractReelId(JsonElement element, out int id)
        {
            id = 0;
            string[] idKeys = { "id", "reel_id", "reelId", "reel_Id", "reel" };
            foreach (var key in idKeys)
            {
                if (element.TryGetProperty(key, out var prop))
                {
                    if (prop.ValueKind == JsonValueKind.Number && prop.TryGetInt32(out id))
                    {
                        return true;
                    }
                    if (prop.ValueKind == JsonValueKind.String && int.TryParse(prop.GetString(), out id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
