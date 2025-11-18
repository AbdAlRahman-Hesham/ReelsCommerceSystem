using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Wishlist;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.Order_ProductEntities;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.WishlistSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IUnitOfWork _unitOfWork;

        public WishlistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GetWishlistProductsRes> GetWishlistProductsAsync(string userId)
        {
            var spec = new WishlistItemSpec(userId);
            var wishlistProducts =await _unitOfWork.Repository<WishlistItem>().GetAllWithSpecAsync(spec);
            var response = new GetWishlistProductsRes();
            if (wishlistProducts == null || !wishlistProducts.Any())
            {
                response.IsEmpty = true;
                response.Count = 0;
                response.Products = new List<WishlistProductRes>();
                return response;
            }
            response.IsEmpty = false;
            response.Count = wishlistProducts.Count();

            response.Products = wishlistProducts.Select(item => new WishlistProductRes
            {
                ProductId = item.ProductId,
                Name = item.Product.Name,
                Description = item.Product.Description,
                Category = item.Product.Category.Name,
                Price = item.Product.Price,
                DiscountPercentage = item.Product.DiscountPercentage,
                BrandName = item.Product.Brand.DisplayName,
                ImageUrl = item.Product.MediaUrl
            }).ToList();

            return response;
        }

        public async Task<WishlistToggleRes> ToggleProductWishlistAsync(string userId, int productId)
        {
            var product = await _unitOfWork.Repository<Product>().GetByIdAsync(productId);
            if (product == null)
                throw new KeyNotFoundException("Product not found.");

            var spec = new WishlistItemSpec(userId, productId);
            var wishlistItem = await _unitOfWork.Repository<WishlistItem>().GetWithSpecAsync(spec);

            bool isLoved;

            if (wishlistItem != null)
            {
                _unitOfWork.Repository<WishlistItem>().Delete(wishlistItem);
                isLoved = false;
            }
            else
            {
                var newWishlistItem = new WishlistItem
                {
                    UserId = userId,
                    ProductId = productId,
                    CreatedAt = DateTime.UtcNow
                };

                await _unitOfWork.Repository<WishlistItem>().AddAsync(newWishlistItem);
                isLoved = true;
            }

            await _unitOfWork.SaveChangesAsync();

            return new WishlistToggleRes
            {
                ProductId = productId,
                IsLoved = isLoved
            };
        }
    }
}
