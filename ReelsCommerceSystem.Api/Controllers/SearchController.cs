using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class SearchController(ISearchService _searchService):AppBaseController
    {
        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string text, int pageNumber = 1, int pageSize = 10)
        {
            var result = await _searchService.SearchAsync(text, pageNumber, pageSize);
            return StatusCode(result.StatusCode, result);
        }
    }
}
