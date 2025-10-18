using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.SpecificationsParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IProductsPerBrandService
    {
        Task<ApiResponse<IQueryable<GetProductRes>>> GetProductsPerBrandAsync(ProductsPerBrandSpecParams productsPerBrandSpecParams);
    }
}
