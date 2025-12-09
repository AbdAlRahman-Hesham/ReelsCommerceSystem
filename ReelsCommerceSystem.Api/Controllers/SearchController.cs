using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class SearchController(ISearchService _searchService):AppBaseController
    {
        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string text, int pageIndex = 1, int pageSize = 10)
        {
            var result = await _searchService.SearchAsync(text, pageIndex, pageSize);
            return StatusCode(result.StatusCode, result);
        }
    }
}
