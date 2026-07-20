using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Application.DTOs.Response.Offer;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IOfferService
    {
        Task<ApiResponse<List<TodayOffersRes>>> GetTodayOffersAsync();
        Task<ApiResponse<int>> CreateOfferAsync(CreateOfferReq request, string userId);
        Task<ApiResponse<bool>> UploadOfferImageAsync(int offerId, IFormFile file);
    }

}
