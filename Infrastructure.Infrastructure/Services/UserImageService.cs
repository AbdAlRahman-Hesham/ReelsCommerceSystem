using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.Interfaces.Services;
using Microsoft.Extensions.Hosting;


namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class UserImageService : IUserImageService
    {
        private readonly string _webRootPath;

        public UserImageService(string webRootPath)
        {
            _webRootPath = webRootPath;
        }

        public async Task<string> SaveUserImageAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return null;

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var relativePath = Path.Combine("images", "users", fileName);
            var fullPath = Path.Combine(_webRootPath, relativePath);

            var directory = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return relativePath.Replace("\\", "/");
        }
    }



}

