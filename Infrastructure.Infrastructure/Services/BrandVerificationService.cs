using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using ReelsCommerceSystem.Application.DTOs.Request.Notification;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Specifications.BrandSpec;
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
    public class BrandVerificationService : IBrandVerificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorageService;
        private readonly INotificationService _notificationService;
        private readonly UserManager<User> _userManager;

        public BrandVerificationService(IUnitOfWork unitOfWork
            , IFileStorageService fileStorageService
            , INotificationService notificationService
            , UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _fileStorageService = fileStorageService;
            _notificationService = notificationService;
            _userManager = userManager;
        }

        public async Task<ApiResponse<string>> VerifyBrandAsync(string userId, VerifyBrandReq request)
        {
            var spec = new BrandByUserIdWithVerificationSpec(userId);
            var brand = await _unitOfWork.Repository<Brand>().GetWithSpecAsync(spec);

            if (brand == null)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "Brand not found for this user.",
                    "لم يتم العثور على براند لهذا المستخدم."
                );
            }

            if (brand.Status == BrandStatus.PENDING_APPROVAL)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Brand is already pending approval.",
                    "البراند بالفعل قيد المراجعة."
                );
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.NotFound,
                    "User not found.",
                    "لم يتم العثور على المستخدم."
                );
            }

            if (user.PhoneNumber != request.PhoneNumber)
            {
                return ApiResponse<string>.ErrorResponse(
                    HttpStatusCode.BadRequest,
                    "Phone number does not match registered user phone.",
                    "رقم الهاتف لا يطابق رقم الهاتف المسجل."
                );
            }

            var frontImagePath = await _fileStorageService.SaveBrandVerificationFileAsync(
                request.IdFrontImage, brand.Id, "IdFront");

            var backImagePath = await _fileStorageService.SaveBrandVerificationFileAsync(
                request.IdBackImage, brand.Id, "IdBack");

            var selfieImagePath = await _fileStorageService.SaveBrandVerificationFileAsync(
                request.SelfieImage, brand.Id, "Selfie");

            if (brand.BrandVerification != null)
            {
                brand.BrandVerification.FullName = request.FullName;
                brand.BrandVerification.NationalId = request.NationalId;
                brand.BrandVerification.TaxNumber = request.TaxNumber;
                brand.BrandVerification.PhoneNumber = request.PhoneNumber;
                brand.BrandVerification.IdFrontImage = frontImagePath;
                brand.BrandVerification.IdBackImage = backImagePath;
                brand.BrandVerification.SelfieImage = selfieImagePath;

                _unitOfWork.Repository<BrandVerification>().Update(brand.BrandVerification);
            }
            else
            {
                var verification = new BrandVerification
                {
                    BrandId = brand.Id,
                    FullName = request.FullName,
                    NationalId = request.NationalId,
                    TaxNumber = request.TaxNumber,
                    PhoneNumber = request.PhoneNumber,
                    IdFrontImage = frontImagePath,
                    IdBackImage = backImagePath,
                    SelfieImage = selfieImagePath
                };

                await _unitOfWork.Repository<BrandVerification>().AddAsync(verification);
            }

            brand.CurrentStep = BrandStep.VERIFICATION;

            brand.Status = BrandStatus.PENDING_APPROVAL;
            brand.CurrentStep = BrandStep.PENDING_REVIEW;
            brand.SubmittedAt = DateTime.UtcNow;

            _unitOfWork.Repository<Brand>().Update(brand);

            await _unitOfWork.SaveChangesAsync();

            // Notify Admin(s)
            await _notificationService.SendBrandSubmittedNotificationAsync(brand);

            return ApiResponse<string>.SuccessResponse(
                "Brand verification submitted successfully.",
                HttpStatusCode.OK,
                "Brand verification submitted successfully.",
                "تم إرسال توثيق البراند بنجاح."
            );
        }
    }
}

