using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Request;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.DTOs.Response.Offer;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.OfferEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.OfferSpec;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ProductSpec;
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
        private readonly IPhotoServive _photoServive;

        public OfferService(IUnitOfWork unitOfWork, IPhotoServive photoServive)
        {
            _unitOfWork = unitOfWork;
            _photoServive = photoServive;
        }

        public async Task<ApiResponse<int>> CreateOfferAsync(CreateOfferReq request, string userId)
        {
            var brandRepo = _unitOfWork.Repository<Brand>();
            var productRepo = _unitOfWork.Repository<Product>();
            var offerRepo = _unitOfWork.Repository<Offer>();

            //  Get Brand
            var brand = await brandRepo.GetWithSpecAsync(new GetBrandByUserId(userId));

            if (brand == null)
            {
                return ApiResponse<int>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Brand not found",
                    "البراند غير موجود");
            }

            // Create Offer
            var offer = new Offer
            {
                Description = request.Description,
                DiscountPercentage = request.DiscountPercentage,
                BrandId = brand.Id,
                OfferProducts = new List<OfferProduct>()
            };

            //  Get valid products 
            if (request.ProductIds != null && request.ProductIds.Any())
            {
                var products = await productRepo.GetAllWithSpecAsync(
                    new ProductsByIdsAndBrandSpec(request.ProductIds, brand.Id)
                );

                if (products.Count != request.ProductIds.Count)
                {
                    return ApiResponse<int>.ErrorResponse(
                        HttpStatusCode.BadRequest,
                        "Invalid products",
                        "في منتجات مش تابعة للبراند");
                }

                foreach (var product in products)
                {
                    offer.OfferProducts.Add(new OfferProduct
                    {
                        ProductId = product.Id
                    });
                }
            }

            //  Save
            await offerRepo.AddAsync(offer);
            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<int>.SuccessResponse(
                offer.Id,
                HttpStatusCode.Created,
                "Offer created",
                "تم إنشاء العرض");
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

        public async Task<ApiResponse<bool>> UploadOfferImageAsync(int offerId, IFormFile file)
        {
            var offerRepo = _unitOfWork.Repository<Offer>();

            var offer = await offerRepo.FirstOrDefaultAsync(o => o.Id == offerId);

            if (offer == null)
                return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Offer not found", "العرض غير موجود");
            var upload = await _photoServive.UploadImageForOfferAsync(file);

            offer.ImageUrl = upload.Url;
            offer.PublicId = upload.PublicId;

            offerRepo.Update(offer);
            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse(
                true,
                HttpStatusCode.OK,
                "Image uploaded",
                "تم رفع الصورة");
        }
    }

}
