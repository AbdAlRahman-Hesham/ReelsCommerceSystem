using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Test;
using ReelsCommerceSystem.Infrastructure.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    [ApiController]
    [Route("api/test/chat")]
    public class TestRoomController : ControllerBase
    {
        private readonly TestRoomService _service;

        public TestRoomController(TestRoomService service)
        {
            _service = service;
        }

        [HttpPost("seed")]
        public async Task<IActionResult> Seed()
        {
            await _service.SeedTestRooms();
            return Ok("Test rooms saved");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _service.GetRoomsAsync();
            return Ok(data);
        }
    }
        


}
