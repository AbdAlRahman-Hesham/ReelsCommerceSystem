using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IPhotoServive
    {
        Task<string> UploadImageAsync(IFormFile file);
        Task<PhotoUploadResult> UploadImageForProductAsync(IFormFile file);
        Task DeleteImageAsync(string publicId);
        Task<PhotoUploadResult> UploadImageForOfferAsync(IFormFile file);
        Task<PhotoUploadResult> UploadImageForCategoryAsync(IFormFile file);

    }
}
