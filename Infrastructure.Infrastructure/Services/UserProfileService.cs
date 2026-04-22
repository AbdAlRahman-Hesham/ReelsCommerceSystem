using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Response.UserProfile;
using ReelsCommerceSystem.Application.DTOs.Request.UserProfile;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReelsCommerceSystem.Infrastructure.Services;

public class UserProfileService : IUserProfileService
{
    private readonly UserManager<User> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserImageService _userImageService;
    private readonly IOtpService _otpService;

    public UserProfileService(
        UserManager<User> userManager,
        IUnitOfWork unitOfWork,
        IUserImageService userImageService,
        IOtpService otpService)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork;
        _userImageService = userImageService;
        _otpService = otpService;
    }

    public async Task<List<Address>> GetShippingAddressesAsync(string userId)
    {
        var addresses = await _unitOfWork.Repository<Address>().GetAllAsync();
        return addresses.Where(a => a.UserId == userId).ToList();
    }

    public async Task<Address> AddShippingAddressAsync(string userId, ShippingAddressReqDto addressDto)
    {
        var address = new Address
        {
            UserId = userId,
            Name = addressDto.Name,
            LastName=addressDto.ShippingLastName,
            Postcode = addressDto.Postcode,
            Country = addressDto.Country,
            Street = addressDto.Street,
            City = addressDto.City,
            PhoneNumber = addressDto.PhoneNumber,
            Apartment=addressDto.ShippingApartment,
            Floor=addressDto.ShippingFloor,
            Building=addressDto.ShippingBuilding,
            IsDefault = addressDto.IsDefault
        };
        var existingDefault = await _unitOfWork.Repository<Address>()
        .FirstOrDefaultAsync(a => a.UserId == userId && a.IsDefault);

        if (existingDefault == null)
        {
            address.IsDefault = true;
        }
        else if (addressDto.IsDefault)
        {
            existingDefault.IsDefault = false;
        }

        await _unitOfWork.Repository<Address>().AddAsync(address);
        await _unitOfWork.SaveChangesAsync();
        return address;
    }

    public async Task<Address> UpdateShippingAddressAsync(
    string userId,
    int addressId,
    UpdateShippingAddressDto dto)
    {
        var address = await _unitOfWork.Repository<Address>()
            .GetByIdAsync(addressId);

        if (address == null || address.UserId != userId)
            throw new NotFoundException("Address not found.");

        if (dto.Name != null)
            address.Name = dto.Name;

        if (dto.Postcode != null)
            address.Postcode = dto.Postcode;

        if (dto.Country != null)
            address.Country = dto.Country;

        if (dto.Street != null)
            address.Street = dto.Street;

        if (dto.City != null)
            address.City = dto.City;

        if (dto.PhoneNumber != null)
            address.PhoneNumber = dto.PhoneNumber;

        if (dto.ShippingLastName != null)
            address.LastName = dto.ShippingLastName;

        if (dto.ShippingFloor != null)
            address.Floor = dto.ShippingFloor;

        if (dto.ShippingBuilding != null)
            address.Building = dto.ShippingBuilding;

        if (dto.ShippingApartment != null)
            address.Apartment = dto.ShippingApartment;

        if (dto.IsDefault.HasValue && dto.IsDefault.Value)
        {
            var existingDefault = await _unitOfWork.Repository<Address>()
                .FirstOrDefaultAsync(a => a.UserId == userId
                                       && a.IsDefault
                                       && a.Id != address.Id);

            if (existingDefault != null)
                existingDefault.IsDefault = false;

            address.IsDefault = true;
        }

        await _unitOfWork.SaveChangesAsync();

        return address;
    }

    public async Task<bool> DeleteShippingAddressAsync(string userId, int addressId)
    {
        var address = await _unitOfWork.Repository<Address>()
            .GetByIdAsync(addressId);

        if (address == null || address.UserId != userId)
            return false;

        bool wasDefault = address.IsDefault;

        _unitOfWork.Repository<Address>().Delete(address);
        await _unitOfWork.SaveChangesAsync();

        if (wasDefault)
        {
            var anotherAddress = await _unitOfWork.Repository<Address>()
                .FirstOrDefaultAsync(a => a.UserId == userId);

            if (anotherAddress != null)
            {
                anotherAddress.IsDefault = true;
                await _unitOfWork.SaveChangesAsync();
            }
        }

        return true;
    }

    public async Task<UpdateProfileResDto> UpdateProfileAsync(string userId, UpdateProfileReqDto profileDto)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        bool emailChanged = !string.Equals(user.Email, profileDto.Email, System.StringComparison.OrdinalIgnoreCase);

        if (emailChanged)
        {
            var existingUser = await _userManager.FindByEmailAsync(profileDto.Email);
            if (existingUser != null && existingUser.Id != userId)
            {
                var errors = new List<ValidationError>
                {
                    new ValidationError
                    {
                        Field = "Email",
                        En = "Email is already in use.",
                        Ar = "البريد الإلكتروني مستخدم بالفعل."
                    }
                };
                throw new BadRequestException(errors);
            }

            user.Email = profileDto.Email;
            user.UserName = profileDto.Email;
            user.EmailConfirmed = false;
        }

        user.FirstName = profileDto.FirstName;
        user.LastName = profileDto.LastName;
        user.DisplayName = $"{profileDto.FirstName} {profileDto.LastName}";
        user.PhoneNumber = profileDto.PhoneNumber;

        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded && emailChanged)
        {
            await _otpService.SendOtpAsync(user.Email!);
        }

        return new UpdateProfileResDto
        {
            IsEmailChanged = emailChanged
        };
    }

    public async Task<bool> UpdatePasswordAsync(string userId, UpdatePasswordReqDto passwordDto)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        var result = await _userManager.ChangePasswordAsync(user, passwordDto.CurrentPassword, passwordDto.NewPassword);
        return result.Succeeded;
    }

    public async Task<bool> UpdateProfileImageAsync(string userId, IFormFile image)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        if (!string.IsNullOrEmpty(user.ImageURL))
        {
            await _userImageService.DeleteUserImageAsync(user.ImageURL);
        }

        var imageUrl = await _userImageService.SaveUserImageAsync(image);
        if (imageUrl == null) return false;

        user.ImageURL = imageUrl;
        var result = await _userManager.UpdateAsync(user);
        return result.Succeeded;
    }


    public async Task<bool> DeleteAccountAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        if (!string.IsNullOrEmpty(user.ImageURL))
        {
            await _userImageService.DeleteUserImageAsync(user.ImageURL);
        }

        var result = await _userManager.DeleteAsync(user);
        return result.Succeeded;
    }
}

