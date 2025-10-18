using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.SpecificationsParams;
using System.Net;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class ProductsPerBrandService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : IProductsPerBrandService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public async Task<ApiResponse<IQueryable<GetProductRes>>> GetProductsPerBrandAsync(ProductsPerBrandSpecParams productsPerBrandSpecParams)
    {
        var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(productsPerBrandSpecParams.BrandId);
        if(brand is null)
        {
            return ApiResponse<IQueryable<GetProductRes>>.ErrorResponse(
                HttpStatusCode.NotFound,
                en: "Brand not found.",
                ar: "العلامة التجارية غير موجودة.",
                errors: new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "brandId",
                        En = "The provided brand ID does not exist.",
                        Ar = "معرف العلامة التجارية غير موجود."
                    }
                }
            );
        }

        var request = _httpContextAccessor.HttpContext?.Request;
        var baseUrl = $"{request?.Scheme}://{request?.Host.Value}/";

        var spec = new ProductsPerBrandSpec(productsPerBrandSpecParams);
        var products = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(spec);
        var result = products.Select(p => new GetProductRes
        {
            ProductName = p.Name,
            ImageUrl = p.MediaUrl != null && p.MediaUrl.StartsWith("Products/")
                        ? $"{baseUrl}{p.MediaUrl}"
                        : p!.MediaUrl??"",
            Price = p.Price,
            Discount = p.DiscountPercentage,
            BrandName = p.Brand.DisplayName
        }).AsQueryable();

        return ApiResponse<IQueryable<GetProductRes>>.SuccessResponse(
            result,
            HttpStatusCode.OK,
            en: "Request completed successfully.",
            ar: "تم تنفيذ الطلب بنجاح."
        );



    }
}
