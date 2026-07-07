using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Params;
using ReelsCommerceSystem.Application.DTOs.Request.Product;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.Products;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
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
    public class BrandProductService : IBrandProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoServive _photoServive;
        private readonly UserManager<User> _userManager;
        private readonly ITranslationService _translationService;

        public BrandProductService(IUnitOfWork unitOfWork, IPhotoServive photoServive, UserManager<User> userManager, ITranslationService translationService)
        {
            _unitOfWork = unitOfWork;
            _photoServive = photoServive;
            _userManager = userManager;
            _translationService = translationService;
        }

        public async Task<ApiResponse<int>> AddProductAsync(AddBrandProductReq request, string userId)
        {
            var brandRepo = _unitOfWork.Repository<Brand>();
            var productRepo = _unitOfWork.Repository<Product>();

            var brand = await brandRepo.FirstOrDefaultAsync(b => b.UserId == userId);

            if (brand == null)
            {
                return ApiResponse<int>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Brand not found",
                    "البراند غير موجود");
            }

            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                CategoryId = request.CategoryId,
                BrandId = brand.Id,
                IsCustomizable = request.IsCustomizable,
                DiscountPercentage = request.DiscountPercentage,

                Images = new List<ProductImage>(),

                AvailableColors = new List<ProductColorMapping>(),


                ProductInformations = new List<ProductInformation>()
            };

            #region Colors + Sizes

            if (request.Colors != null && request.Colors.Any())
            {
                foreach (var colorReq in request.Colors)
                {
                    var colorMapping = new ProductColorMapping
                    {
                        ProductColorId = colorReq.ProductColorId,
                        AvailableSizes = new List<ProductSizeMapping>()
                    };

                    foreach (var sizeReq in colorReq.Sizes)
                    {
                        colorMapping.AvailableSizes.Add(new ProductSizeMapping
                        {
                            ProductSizeId = sizeReq.ProductSizeId,
                            Quantity = sizeReq.Quantity
                        });
                    }

                    product.AvailableColors.Add(colorMapping);
                }
            }

            #endregion

            #region Product Informations

            if (request.Informations != null && request.Informations.Any())
            {
                foreach (var info in request.Informations)
                {
                    product.ProductInformations.Add(new ProductInformation
                    {
                        Key = info.Key,
                        Value = info.Value,
                        Type = info.Type,
                        Group = info.Group,
                        DisplayOrder = info.DisplayOrder
                    });
                }
            }

            #endregion

            #region Auto-translate description and info fields

            if (!string.IsNullOrWhiteSpace(request.Description))
            {
                var detected = await _translationService.DetectLanguageAsync(request.Description);
                if (detected.Success && detected.Language != "ar")
                {
                    var translation = await _translationService.TranslateAsync(request.Description, detected.Language, "ar");
                    if (translation.Success && !string.IsNullOrWhiteSpace(translation.TranslatedText))
                    {
                        product.ArDescription = translation.TranslatedText;
                    }
                }
            }

            if (request.Informations != null)
            {
                foreach (var info in product.ProductInformations)
                {
                    if (!string.IsNullOrWhiteSpace(info.Key))
                    {
                        var keyLang = await _translationService.DetectLanguageAsync(info.Key);
                        if (keyLang.Success && keyLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Key, keyLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                            {
                                info.ArKey = t.TranslatedText;
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(info.Value))
                    {
                        var valLang = await _translationService.DetectLanguageAsync(info.Value);
                        if (valLang.Success && valLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Value, valLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                            {
                                info.ArValue = t.TranslatedText;
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(info.Group))
                    {
                        var grpLang = await _translationService.DetectLanguageAsync(info.Group);
                        if (grpLang.Success && grpLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Group, grpLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                            {
                                info.ArGroup = t.TranslatedText;
                            }
                        }
                    }
                }
            }

            #endregion

            await productRepo.AddAsync(product);

            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<int>.SuccessResponse(
                product.Id,
                HttpStatusCode.Created,
                "Product created",
                "تم إضافة المنتج");
        }
        public async Task<ApiResponse<bool>> UploadImagesAsync(int productId, List<IFormFile> images, string userId)
        {
            var productRepo = _unitOfWork.Repository<Product>();

            var product = await productRepo.FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Product not found",
                    "المنتج غير موجود");
            }

            product.Images ??= new List<ProductImage>();

            foreach (var file in images)
            {
                var upload = await _photoServive.UploadImageForProductAsync(file);

                await _unitOfWork.Repository<ProductImage>().AddAsync(
                    new ProductImage
                    {
                        Url = upload.Url,
                        PublicId = upload.PublicId,
                        ProductId = productId
                    });
            }

            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse(
                true,
                HttpStatusCode.OK,
                "Images uploaded",
                "تم رفع الصور");
        }

        public async Task<ApiResponse<bool>> DeleteImageAsync(int productId, int imageId, string userId)
        {
            var productRepo = _unitOfWork.Repository<Product>();
            var imageRepo = _unitOfWork.Repository<ProductImage>();

            var product = await productRepo.GetWithSpecAsync(new ProductWithImagesSpec(productId));

            if (product == null)
                return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Product not found", "المنتج غير موجود");

            var image = product.Images.FirstOrDefault(i => i.Id == imageId);

            if (image == null)
                return ApiResponse<bool>.ErrorResponse(HttpStatusCode.NotFound, "Image not found", "الصورة غير موجودة");

            // 1. delete from cloudinary
            if (!string.IsNullOrWhiteSpace(image.PublicId))
            {
                await _photoServive.DeleteImageAsync(image.PublicId);
            }

            // 2. delete from DB
            imageRepo.Delete(image);

            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse(
                true,
                HttpStatusCode.OK,
                "Image deleted successfully",
                "تم حذف الصورة بنجاح");
        }

        public async Task<ApiResponse<bool>> DeleteProductAsync(int productId, string userId)
        {
            var productRepo = _unitOfWork.Repository<Product>();
            var imageRepo = _unitOfWork.Repository<ProductImage>();

            var product = await productRepo
                .GetWithSpecAsync(new ProductWithImagesSpec(productId));

            if (product == null)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Product not found",
                    "المنتج غير موجود");
            }

            // delete images from cloudinary + db
            if (product.Images != null && product.Images.Any())
            {
                foreach (var img in product.Images.ToList())
                {
                    if (!string.IsNullOrEmpty(img.PublicId))
                    {
                        await _photoServive.DeleteImageAsync(img.PublicId);
                    }

                    imageRepo.Delete(img);
                }
            }

            productRepo.Delete(product);

            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse(
                true,
                HttpStatusCode.OK,
                "Product deleted",
                "تم حذف المنتج");
        }

        public async Task<ApiResponse<PaginationResponse<GetBrandProductsRes>>> GetBrandProductsAsync(GetBrandProductsParams param, int brandId)
        {
            var repo = _unitOfWork.Repository<Product>();

            var spec = new GetBrandProductsSpec(param, brandId);
            var countSpec = new GetBrandProductCountSpec(param, brandId);

            var products = await repo.GetAllWithSpecAsync(spec);
            var totalCount = await repo.CountAsync(countSpec);

            var data = products.Select(p => new GetBrandProductsRes
            {
                Id = p.Id,
                Name = p.Name,
                CreatedAt = p.CreatedAt,
                Price = p.Price,
                Quantity = p.Quantity,
                Status = p.Status,
                Image = (p.Images != null && p.Images.Any())
               ? p.Images.First().Url
               : null
            }).ToList();

            var meta = new Meta
            {
                PageNumber = param.PageIndex,
                PageSize = param.PageSize,
                TotalRecords = totalCount,
                HasNextPage = (param.PageIndex * param.PageSize) < totalCount,
                HasPreviousPage = param.PageIndex > 1
            };

            return PaginationResponse<GetBrandProductsRes>.SuccessResponse(
                data,
                meta,
                HttpStatusCode.OK
            );


        }

        public async Task<ApiResponse<bool>> EditProductAsync(EditProductReq request, string userId)
        {
            var brandRepo = _unitOfWork.Repository<Brand>();
            var productRepo = _unitOfWork.Repository<Product>();

            var brand = await brandRepo.FirstOrDefaultAsync(b => b.UserId == userId);

            if (brand == null)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Brand not found",
                    "البراند غير موجود");
            }

            var product = await productRepo.GetWithSpecAsync(new ProductFullSpec(request.ProductId));

            if (product == null)
            {
                return ApiResponse<bool>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Product not found",
                    "المنتج غير موجود");
            }

            // ================= BASIC INFO =================
            if (!string.IsNullOrWhiteSpace(request.Name))
                product.Name = request.Name;

            if (!string.IsNullOrWhiteSpace(request.Description))
                product.Description = request.Description;

            if (request.Price.HasValue)
                product.Price = request.Price.Value;

            if (request.CategoryId.HasValue)
                product.CategoryId = request.CategoryId.Value;

            if (request.IsCustomizable.HasValue)
                product.IsCustomizable = request.IsCustomizable.Value;

            if (request.DiscountPercentage.HasValue)
                product.DiscountPercentage = request.DiscountPercentage;


            // ================= COLORS + SIZES =================
            if (request.Colors != null)
            {
                product.AvailableColors.Clear();

                foreach (var color in request.Colors)
                {
                    var colorMapping = new ProductColorMapping
                    {
                        ProductColorId = color.ProductColorId,
                        AvailableSizes = new List<ProductSizeMapping>()
                    };

                    foreach (var size in color.Sizes)
                    {
                        colorMapping.AvailableSizes.Add(new ProductSizeMapping
                        {
                            ProductSizeId = size.ProductSizeId,
                            Quantity = size.Quantity
                        });
                    }

                    product.AvailableColors.Add(colorMapping);
                }
            }


            // ================= PRODUCT INFORMATIONS =================
            if (request.Informations != null)
            {
                product.ProductInformations.Clear();

                foreach (var info in request.Informations)
                {
                    product.ProductInformations.Add(new ProductInformation
                    {
                        Key = info.Key,
                        Value = info.Value,
                        Type = info.Type,
                        Group = info.Group,
                        DisplayOrder = info.DisplayOrder
                    });
                }
            }


            // ================= AUTO-TRANSLATE =================

            if (!string.IsNullOrWhiteSpace(request.Description))
            {
                var detected = await _translationService.DetectLanguageAsync(request.Description);
                if (detected.Success && detected.Language != "ar")
                {
                    var translation = await _translationService.TranslateAsync(request.Description, detected.Language, "ar");
                    if (translation.Success && !string.IsNullOrWhiteSpace(translation.TranslatedText))
                    {
                        product.ArDescription = translation.TranslatedText;
                    }
                }
            }

            if (request.Informations != null)
            {
                foreach (var info in product.ProductInformations)
                {
                    if (!string.IsNullOrWhiteSpace(info.Key))
                    {
                        var keyLang = await _translationService.DetectLanguageAsync(info.Key);
                        if (keyLang.Success && keyLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Key, keyLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                                info.ArKey = t.TranslatedText;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(info.Value))
                    {
                        var valLang = await _translationService.DetectLanguageAsync(info.Value);
                        if (valLang.Success && valLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Value, valLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                                info.ArValue = t.TranslatedText;
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(info.Group))
                    {
                        var grpLang = await _translationService.DetectLanguageAsync(info.Group);
                        if (grpLang.Success && grpLang.Language != "ar")
                        {
                            var t = await _translationService.TranslateAsync(info.Group, grpLang.Language, "ar");
                            if (t.Success && !string.IsNullOrWhiteSpace(t.TranslatedText))
                                info.ArGroup = t.TranslatedText;
                        }
                    }
                }
            }


            // ================= SAVE =================
            productRepo.Update(product);
            await _unitOfWork.SaveChangesAsync();

            return ApiResponse<bool>.SuccessResponse(
                true,
                HttpStatusCode.OK,
                "Product updated successfully",
                "تم تعديل المنتج بنجاح");
        }
    }
}
