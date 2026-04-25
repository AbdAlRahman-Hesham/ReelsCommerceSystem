using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Offer;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec;
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
    public class OfferService : IOfferService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OfferService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<List<TodayOffersRes>>> GetTodayOffersAsync()
        {
            try
            {
                var spec = new TodayOfferSpecification();

                var offers = await _unitOfWork.Repository<Offer>().GetAllWithSpecAsync(spec);

                if (!offers.Any())
                {
                    // Fallback: Get most recent offers
                    offers = await _unitOfWork.Repository<Offer>().GetAllWithSpecAsync(new RecentOffersSpecification(5));
                }

                if (!offers.Any())
                {
                    return ApiResponse<List<TodayOffersRes>>.SuccessResponse(
                        new List<TodayOffersRes>(),
                        HttpStatusCode.OK,
                        "No offers found.",
                        "لا يوجد عروض."
                    );
                }

                // mapping
                var result = offers.Select(offer => new TodayOffersRes
                {
                    OfferId = offer.Id,
                    BrandId = offer.BrandId,
                    BrandName = offer.Brand.DisplayName,
                    BrandImage = offer.Brand.LogoUrl,
                    OfferImage = offer.ImageUrl,
                    Description = offer.Description,

                    Products = offer.OfferProducts.Select(op => new OfferProductRes
                    {
                        Id = op.Product.Id,
                        Name = op.Product.Name,
                        Price = op.Product.Price,
                        ProductMediaUrls = op.Product.Images?
                                           .Select(x => x.Url)
                                           .ToList() ?? new List<string>()
                    }).ToList()

                }).ToList();

                return ApiResponse<List<TodayOffersRes>>.SuccessResponse(
                    result,
                    HttpStatusCode.OK
                );
            }
            catch (Exception ex)
            {
                return ApiResponse<List<TodayOffersRes>>.ErrorResponse(
                    HttpStatusCode.InternalServerError,
                    "Server error occurred.",
                    "حدث خطأ في السيرفر."
                );
            }
        }
    }

}
