using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.ViewSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class UserProductViewService : IUserProductViewService
    {
        private readonly IGenericRepository<UserProductView> _userProductViewRepository;
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public UserProductViewService(
            IGenericRepository<UserProductView> userProductViewRepository,
            UserManager<User> userManager,
            IUnitOfWork unitOfWork)
        {
            _userProductViewRepository = userProductViewRepository;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public async Task RecordProductViewAsync(string userId, int productId)
        {
            var userExists = await _userManager.FindByIdAsync(userId);
            if (userExists is null)
                return;

            var existingView = await _userProductViewRepository
                       .FirstOrDefaultAsync(v => v.UserId == userId && v.ProductId == productId);

            if (existingView != null)
            {
                existingView.UpdatedAt = DateTime.UtcNow;
                _userProductViewRepository.Update(existingView);
                await _unitOfWork.SaveChangesAsync();
                return;
            }

            var view = new UserProductView
            {
                UserId = userId,
                ProductId = productId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _userProductViewRepository.AddAsync(view);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<UserProductViewDto>> GetRecentViewsAsync(string userId, int limit)
        {
            var spec = new RecentUserViewsSpec(userId, limit);
            var views = await _userProductViewRepository.GetAllWithSpecAsync(spec);

            return views.Select(v => new UserProductViewDto
            {
                UserId = v.UserId,
                Username = v.User.UserName,   
                ProductId = v.ProductId,
                ProductName = v.Product.Name,
                Price = v.Product.Price,
                ImageUrls = v.Product.Images?.Select(img => img.Url).ToList() ?? new List<string>(),
                CreatedAt = v.CreatedAt,
                UpdatedAt = v.UpdatedAt
            }).ToList();
        }
    }
}
