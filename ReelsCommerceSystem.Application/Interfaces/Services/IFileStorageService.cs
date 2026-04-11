using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IFileStorageService
    {
        Task<string> SaveBrandVerificationFileAsync(IFormFile file, int brandId, string folderName);
    }
}
