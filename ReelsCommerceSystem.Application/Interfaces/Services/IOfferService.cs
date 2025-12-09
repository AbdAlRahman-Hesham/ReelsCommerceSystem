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
    }
}
