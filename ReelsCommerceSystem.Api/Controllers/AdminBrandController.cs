using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Reject;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Shared.Utilities;

namespace ReelsCommerceSystem.Api.Controllers
{
    [Route("api/admin/brand-requests")]
    [ApiController]
    [Authorize(Roles = SystemRoles.Admin)]
    public class AdminBrandController : AppBaseController
    {
        private readonly IAdminBrandService _service;

        public AdminBrandController(IAdminBrandService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetBrandRequests(
            [FromQuery] string? status,
            [FromQuery] string? search,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 20)
        {
            var result = await _service.GetBrandRequestsAsync(status, search, page, pageSize);

            return Ok(new
            {
                success = true,
                message = "Brand requests retrieved successfully",
                data = result
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDetails(int id)
        {
            var result = await _service.GetDetailsAsync(id);

            return Ok(new
            {
                success = true,
                message = "Brand request details retrieved successfully",
                data = result
            });
        }

        [HttpPost("{id}/approve")]
        public async Task<IActionResult> Approve(int id)
        {
            await _service.ApproveAsync(id);

            return Ok(new
            {
                success = true,
                message = "Brand approved successfully"
            });
        }

        [HttpPost("{id}/reject")]
        public async Task<IActionResult> Reject(int id, [FromBody] RejectBrandDto dto)
        {
            await _service.RejectAsync(id, dto.ReasonId);

            return Ok(new
            {
                success = true,
                message = "Brand rejected successfully"
            });
        }

        [HttpPost("{id}/ban")]
        public async Task<IActionResult> Ban(int id)
        {
            await _service.BanUserAsync(id);

            return Ok(new
            {
                success = true,
                message = "User banned successfully"
            });
        }

        [HttpGet("pending-count")]
        public async Task<IActionResult> GetPendingCount()
        {
            var count = await _service.GetPendingCountAsync();

            return Ok(new
            {
                success = true,
                data = new { count }
            });
        }
    }
}
