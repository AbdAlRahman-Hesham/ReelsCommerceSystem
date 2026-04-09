using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class FileStorageService : IFileStorageService
    {
        private readonly IWebHostEnvironment _environment;

        public FileStorageService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<string> SaveBrandVerificationFileAsync(IFormFile file, int brandId, string folderName)
        {
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".webp" };

            if (!allowedExtensions.Contains(extension))
                throw new Exception("Only JPG, JPEG, PNG, and WEBP images are allowed.");

            var uploadsFolder = Path.Combine(
                _environment.WebRootPath,
                "BrandVerification",
                $"Brand_{brandId}",
                folderName
            );

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            var fileName = $"{Guid.NewGuid()}{extension}";
            var filePath = Path.Combine(uploadsFolder, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(stream);

            return $"/BrandVerification/Brand_{brandId}/{folderName}/{fileName}";
        }
    }
}
