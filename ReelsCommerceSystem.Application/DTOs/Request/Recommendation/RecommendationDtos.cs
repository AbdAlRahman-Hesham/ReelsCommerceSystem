using System.Text.Json.Serialization;

namespace ReelsCommerceSystem.Application.DTOs.Request.Recommendation
{
    public class BrandPayloadDto
    {
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }

    public class ReelPayloadDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("videoUrl")]
        public string VideoUrl { get; set; } = string.Empty;

        [JsonPropertyName("brand")]
        public BrandPayloadDto Brand { get; set; } = null!;

        [JsonPropertyName("productReels")]
        public List<object> ProductReels { get; set; } = new();

        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; } = string.Empty;

        [JsonPropertyName("numOfLikes")]
        public int NumOfLikes { get; set; }

        [JsonPropertyName("numOfWatches")]
        public int NumOfWatches { get; set; }
    }

    public class BatchProcessPayloadDto
    {
        [JsonPropertyName("reels")]
        public List<ReelPayloadDto> Reels { get; set; } = new();
    }

    public class ReelUpdatePayloadDto
    {
        [JsonPropertyName("reelId")]
        public int ReelId { get; set; }

        [JsonPropertyName("likes")]
        public int Likes { get; set; }

        [JsonPropertyName("watches")]
        public int Watches { get; set; }
    }

    public class BatchUpdatePayloadDto
    {
        [JsonPropertyName("reels")]
        public List<ReelUpdatePayloadDto> Reels { get; set; } = new();
    }

    public class UserReelViewPayloadDto
    {
        [JsonPropertyName("reelId")]
        public int ReelId { get; set; }

        [JsonPropertyName("watchedDurationSeconds")]
        public int WatchedDurationSeconds { get; set; }

        [JsonPropertyName("videoDurationSeconds")]
        public int VideoDurationSeconds { get; set; }
    }

    public class UserReelLikePayloadDto
    {
        [JsonPropertyName("reelId")]
        public int ReelId { get; set; }
    }

    public class UserPayloadDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("userReelViews")]
        public List<UserReelViewPayloadDto> UserReelViews { get; set; } = new();

        [JsonPropertyName("userReelLikes")]
        public List<UserReelLikePayloadDto> UserReelLikes { get; set; } = new();
    }
}
