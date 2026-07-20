using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services
{
    public interface IBrandProductService
    {
        Task<ApiResponse<PaginationResponse<GetBrandProductsRes>>> GetBrandProductsAsync(
        GetBrandProductsParams param,
        int brandId);

        Task<ApiResponse<int>> AddProductAsync(AddBrandProductReq request, string userId);

        Task<ApiResponse<bool>> EditProductAsync(EditProductReq request, string userId);

        Task<ApiResponse<bool>> DeleteProductAsync(int productId, string userId);
        Task<ApiResponse<bool>> UploadImagesAsync(int productId, List<IFormFile> images, string userId);
        Task<ApiResponse<bool>> DeleteImageAsync(int productId, int imageId, string userId);
    }
}
