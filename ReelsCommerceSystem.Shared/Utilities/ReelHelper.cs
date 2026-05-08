using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Shared.Utilities
{
    public static class ReelHelper
    {
        public static string GenerateThumbnailUrl(string videoUrl, int second = 1)
        {
            if (string.IsNullOrWhiteSpace(videoUrl))
                throw new ArgumentException("Video URL cannot be empty");

            var split = videoUrl.Split("/video/upload/");
            if (split.Length != 2)
                throw new Exception("Invalid Cloudinary URL format");

            var prefix = split[0];
            var suffix = split[1];

            if (suffix.EndsWith(".mp4"))
                suffix = suffix[..^4] + ".jpg";

            string transform = $"video/upload/so_{second},f_jpg/";

            return $"{prefix}/{transform}{suffix}";
        }
    }
}
