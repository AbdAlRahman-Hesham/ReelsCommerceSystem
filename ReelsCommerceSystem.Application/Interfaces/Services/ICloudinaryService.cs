using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ICloudinaryService
    {
        Task<string> UploadImageAsync(
        IFormFile file,
        string folder = "Posts");

        Task<string> UploadVideoAsync(
            IFormFile file,
            string folder = "reels");
    }
}
