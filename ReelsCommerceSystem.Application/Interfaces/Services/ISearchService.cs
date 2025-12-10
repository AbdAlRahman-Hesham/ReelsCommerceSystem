using ReelsCommerceSystem.Application.DTOs.Response.Search;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface ISearchService
    {
        Task<ApiResponse<ReelProductSearchRes>> SearchAsync(string text, int pageNumber, int pageSize);
    }
}
