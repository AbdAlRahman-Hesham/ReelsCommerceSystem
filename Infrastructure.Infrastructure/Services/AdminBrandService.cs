using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.DTOs.Response.Admin;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    public class AdminBrandService : IAdminBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationService _notificationService;
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _dbContext;

        public AdminBrandService(IUnitOfWork unitOfWork,
                                 INotificationService notificationService,
                                 UserManager<User> userManager,
                                 AppDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _notificationService = notificationService;
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<PagedResponse<BrandRequestListDto>> GetBrandRequestsAsync(
            string? status = null,
            string? search = null,
            int page = 1,
            int pageSize = 20)
        {
            var query = _dbContext.Brands
                .Include(b => b.user)
                .Include(b => b.BrandVerification)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(status) &&
                Enum.TryParse<BrandStatus>(status.ToUpperInvariant(), out var statusFilter))
            {
                query = query.Where(b => b.Status == statusFilter);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                var searchLower = search.ToLowerInvariant();
                query = query.Where(b =>
                    b.DisplayName.ToLower().Contains(searchLower) ||
                    b.user.DisplayName.ToLower().Contains(searchLower) ||
                    b.user.Email.ToLower().Contains(searchLower) ||
                    b.user.PhoneNumber!.Contains(searchLower));
            }

            var totalCount = await query.CountAsync();

            var brands = await query
                .OrderByDescending(b => b.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(b => new BrandRequestListDto
                {
                    Id = b.Id,
                    BrandName = b.DisplayName,
                    LogoUrl = b.LogoUrl,
                    OwnerName = b.user.DisplayName,
                    OwnerPhone = b.user.PhoneNumber ?? "",
                    Country = b.Country,
                    Category = b.Category,
                    SubmittedAt = b.SubmittedAt ?? b.CreatedAt,
                    Status = b.Status.ToString()
                })
                .ToListAsync();

            return new PagedResponse<BrandRequestListDto>
            {
                Items = brands,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize
            };
        }

        public async Task<BrandRequestDetailsDto> GetDetailsAsync(int id)
        {
            var brand = await _dbContext.Brands
                .AsNoTracking()
                .Include(b => b.user)
                    .ThenInclude(u => u.Interests)
                        .ThenInclude(ui => ui.Interest)
                .Include(b => b.BrandVerification)
                .Include(b => b.RejectionReason)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            var user = brand.user;

            return new BrandRequestDetailsDto
            {
                Id = brand.Id,
                Status = brand.Status.ToString(),
                CurrentStep = (int)brand.CurrentStep,
                LastFailedStep = brand.LastFailedStep != null ? (int)brand.LastFailedStep : null,
                SubmittedAt = brand.SubmittedAt,
                CreatedAt = brand.CreatedAt,
                RejectionReason = brand.RejectionReason != null
                    ? new RejectionReasonDto
                    {
                        Id = brand.RejectionReason.Id,
                        Code = brand.RejectionReason.Code,
                        Description = brand.RejectionReason.Description
                    }
                    : null,
                User = new UserInfoDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email ?? "",
                    Phone = user.PhoneNumber ?? "",
                    Gender = user.Gender,
                    DateOfBirth = user.DateOfBirth,
                    ProfileImage = user.ImageURL,
                    Interests = user.Interests?
                        .Where(ui => ui.Interest != null)
                        .Select(ui => ui.Interest.Name)
                        .ToList() ?? new()
                },
                Brand = new BrandInfoDto
                {
                    DisplayName = brand.DisplayName,
                    LogoUrl = brand.LogoUrl,
                    Description = brand.Description,
                    Category = brand.Category,
                    NumberOfEmployees = brand.NumberOfEmployees,
                    Country = brand.Country,
                    Governorate = brand.Governorate,
                    District = brand.District,
                    ReturnPolicyAsHtml = brand.ReturnPolicyAsHtml
                },
                Verification = brand.BrandVerification != null
                    ? new VerificationDto
                    {
                        FullName = brand.BrandVerification.FullName,
                        NationalId = brand.BrandVerification.NationalId,
                        TaxNumber = brand.BrandVerification.TaxNumber,
                        PhoneNumber = brand.BrandVerification.PhoneNumber,
                        IdFrontImage = brand.BrandVerification.IdFrontImage,
                        IdBackImage = brand.BrandVerification.IdBackImage,
                        SelfieImage = brand.BrandVerification.SelfieImage
                    }
                    : null
            };
        }

        public async Task ApproveAsync(int id)
        {
            var brand = await _dbContext.Brands
                .Include(b => b.user)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            if (brand.Status != BrandStatus.PENDING_APPROVAL)
                throw new BadRequestException("Invalid status");

            brand.Status = BrandStatus.APPROVED;
            brand.CurrentStep = BrandStep.COMPLETED;
            brand.LastFailedStep = null;

            _unitOfWork.Repository<Brand>().Update(brand);
            await _unitOfWork.SaveChangesAsync();

            var owner = brand.user;
            if (owner != null)
            {
                var roles = await _userManager.GetRolesAsync(owner);
                if (!roles.Contains("Brand Owner"))
                    await _userManager.AddToRoleAsync(owner, "Brand Owner");
            }

            await _notificationService.SendBrandApprovedNotificationAsync(brand);
        }

        public async Task RejectAsync(int id, int reasonId)
        {
            var brand = await _dbContext.Brands
                .Include(b => b.user)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            if (brand.Status != BrandStatus.PENDING_APPROVAL)
                throw new BadRequestException("Invalid status");

            var reason = await _unitOfWork.Repository<RejectionReason>().GetByIdAsync(reasonId);
            if (reason == null)
                throw new BadRequestException("Invalid rejection reason");

            brand.Status = BrandStatus.REJECTED;
            brand.RejectionReasonId = reasonId;
            brand.LastFailedStep = BrandStep.VERIFICATION;

            _unitOfWork.Repository<Brand>().Update(brand);
            await _unitOfWork.SaveChangesAsync();

            await _notificationService.SendBrandRejectedNotificationAsync(brand, reason.Description);
        }

        public async Task BanUserAsync(int id)
        {
            var brand = await _dbContext.Brands
                .Include(b => b.user)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (brand == null)
                throw new NotFoundException("Brand not found");

            var user = brand.user;
            if (user == null)
                throw new NotFoundException("User not found");

            user.IsBanned = true;
            brand.Status = BrandStatus.BANNED;

            _unitOfWork.Repository<Brand>().Update(brand);
            await _userManager.UpdateAsync(user);

            if (await _userManager.IsInRoleAsync(user, "Brand Owner"))
                await _userManager.RemoveFromRoleAsync(user, "Brand Owner");

            await _unitOfWork.SaveChangesAsync();

            await _notificationService.SendBrandBannedNotificationAsync(brand);
        }

        public async Task<int> GetPendingCountAsync()
        {
            return await _dbContext.Brands
                .CountAsync(b => b.Status == BrandStatus.PENDING_APPROVAL);
        }
    }
}
