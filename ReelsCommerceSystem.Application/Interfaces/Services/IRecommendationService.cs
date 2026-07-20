using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IRecommendationService
    {
        Task ProcessReelAsync(Reel reel);
        Task UpdateReelMetadataAsync(int reelId, int likes, int watches);
        Task DeleteReelAsync(int reelId);
        Task<List<int>> GetRecommendedReelIdsAsync(string userId, int topK = 10);
    }
}
