using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.SpecificationsParams;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<ApiResponse<PaginationResponse<ProductPag>>> GetProductsAsync(ProductSpecParams productSpecParams);
    }
}
