using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class RejectionReasonController : AppBaseController
    {
        private readonly IRejectionReasonService _rejectionReasonService;
        public RejectionReasonController(IRejectionReasonService rejectionReasonService)
        {
            _rejectionReasonService = rejectionReasonService;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _rejectionReasonService.GetAllAsync();
            return StatusCode(response.StatusCode, response);
        }
    }
}
