using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.Brand;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Utilities;


namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class AdminBrandService : IAdminBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;
        private readonly UserManager<User> _userManager;

        public AdminBrandService(IUnitOfWork unitOfWork,
                                 INotificationService notificationService, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
            _userManager = userManager;
        }

        public async Task ApproveAsync(int id)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            if (brand.Status != BrandStatus.PENDING_APPROVAL)
                throw new BadRequestException("Invalid status");

            brand.Status = BrandStatus.APPROVED;
            brand.CurrentStep = BrandStep.COMPLETED;

            _unitOfWork.Repository<Brand>().Update(brand);
            await _unitOfWork.SaveChangesAsync();

            // Assign "Brand Owner" + "User" roles to the brand owner
            var owner = await _userManager.FindByIdAsync(brand.UserId);
            if (owner != null)
            {
                if (!await _userManager.IsInRoleAsync(owner, SystemRoles.BrandOwner))
                    await _userManager.AddToRoleAsync(owner, SystemRoles.BrandOwner);

                if (!await _userManager.IsInRoleAsync(owner, SystemRoles.User))
                    await _userManager.AddToRoleAsync(owner, SystemRoles.User);
            }

            await _notificationService.SendBrandApprovedNotificationAsync(brand);
        }


        public async Task BanUserAsync(int id)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            var user = await _userManager.FindByIdAsync(brand.UserId);

            if (user == null)
                throw new NotFoundException("User not found");

            user.IsBanned = true;

            await _userManager.UpdateAsync(user);
        }



        public async Task<BrandDetailsDto> GetDetailsAsync(int id)
        {
            var spec = new GetBrandDetailsSpec(id);

            var brand = await _unitOfWork.Repository<Brand>()
                .GetWithSpecAsync(spec);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            return new BrandDetailsDto
            {
                Id = brand.Id,
                DisplayName = brand.DisplayName,
                Status = brand.Status.ToString(),
                UserName = brand.user?.DisplayName
            };
        }


        public async Task<List<BrandDetailsDto>> GetPendingAsync()
        {
            var spec = new GetPendingBrandsSpec();

            var brands = await _unitOfWork.Repository<Brand>()
                .GetAllWithSpecAsync(spec);

            return brands.Select(b => new BrandDetailsDto
            {
                Id = b.Id,
                DisplayName = b.DisplayName,
                Status = b.Status.ToString(),
                UserName = b.user.DisplayName
            }).ToList();
        }



        public async Task RejectAsync(int id, int reasonId)
        {
            var brand = await _unitOfWork.Repository<Brand>().GetByIdAsync(id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            if (brand.Status != BrandStatus.PENDING_APPROVAL)
                throw new BadRequestException("Invalid status");

            var reason = await _unitOfWork.Repository<RejectionReason>()
                .GetByIdAsync(reasonId);

            if (reason == null)
                throw new BadRequestException("Invalid rejection reason");

            brand.Status = BrandStatus.REJECTED;
            brand.RejectionReasonId = reasonId;

         
            brand.CurrentStep = BrandStep.VERIFICATION;

            _unitOfWork.Repository<Brand>().Update(brand);
            await _unitOfWork.SaveChangesAsync();

            await _notificationService
                .SendBrandRejectedNotificationAsync(brand, reason.Description);
        }
    }
}
