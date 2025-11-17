using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Shared.Responses;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IRelatedProductService
    {
        Task<ApiResponse<List<ProductPag>>> GetRelatedProductsAsync(int currentProductId, int take = 3);
    }
}
