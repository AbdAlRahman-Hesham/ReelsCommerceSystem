using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IUserImageService
    {
        Task<string> SaveUserImageAsync(IFormFile ProfileImage);
    }
}
