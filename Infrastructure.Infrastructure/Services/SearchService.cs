using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Search;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.ReelEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.SearchSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class SearchService(IUnitOfWork _unitOfWork) : ISearchService
    {
        public async Task<ApiResponse<ReelProductSearchRes>> SearchAsync(string text, int pageNumber, int pageSize)
        {
            // ----- Reels -----
            var reelSpec = new ReelSearchSpec(text, pageNumber, pageSize);
            var reelsList=await _unitOfWork.Repository<Reel>().GetAllWithSpecAsync(reelSpec);

            var totalReels = reelsList.Count();

            var reelsResult = reelsList.Select(r => new ReelSearchRes
            {
                ReelId = r.Id,
                Title = r.Title,
                VideoUrl = r.VideoUrl,
                CreatedAt = r.CreatedAt,
                NumOfLikes = r.NumOfLikes,
                NumOfWatches = r.NumOfWatches
            }).ToList();
            var reelPagination = new PaginationResponse<ReelSearchRes>
            {
                Data = reelsResult,
                Meta = new Meta
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalRecords = totalReels,
                    HasPreviousPage = pageNumber > 1,
                    HasNextPage = pageNumber * pageSize < totalReels
                }
            };
            // ----- Products -----
            var productSpec = new ProductSearchSpec(text, pageNumber, pageSize);
            var productsList = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(productSpec);

            var totalProducts = productsList.Count();

            var productsResult = productsList.Select(p => new ProductSearchRes
            {
                ProductId = p.Id,
                Name = p.Name,
                Description = p.Description,
                ArDescription = p.ArDescription,
                MainImageUrl = p.MediaUrl,
                Price = p.Price,

            }).ToList();
            var productPagination = new PaginationResponse<ProductSearchRes>
            {
                Data = productsResult,
                Meta = new Meta
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalRecords = totalProducts,
                    HasPreviousPage = pageNumber > 1,
                    HasNextPage = pageNumber * pageSize < totalProducts
                }
            };
            var response = new ReelProductSearchRes
            {
                Reels = reelPagination,
                Products = productPagination
            };

            return ApiResponse<ReelProductSearchRes>.SuccessResponse(
                response,
                HttpStatusCode.OK,
                "Search completed",
                "تم تنفيذ البحث بنجاح"
            );
        }
    }
}
