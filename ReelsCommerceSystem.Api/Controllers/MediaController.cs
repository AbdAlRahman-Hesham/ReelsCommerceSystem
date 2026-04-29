using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class MediaController : AppBaseController
    {
        private readonly IPhotoServive _photoService;
        public MediaController(IPhotoServive photoService)
        {
            _photoService = photoService;
        }

        [HttpPost("upload")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Upload( IFormFile file)
        {
            var url = await _photoService.UploadImageAsync(file);
            return Ok(new { imageUrl = url });
        }

    }
}
