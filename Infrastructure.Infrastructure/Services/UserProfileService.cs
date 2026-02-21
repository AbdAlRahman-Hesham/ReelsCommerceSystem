using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ReelsCommerceSystem.Application.DTOs.Request.UserProfile;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReelsCommerceSystem.Infrastructure.Services;

public class UserProfileService : IUserProfileService
{
    private readonly UserManager<User> _userManager;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserImageService _userImageService;

    public UserProfileService(
        UserManager<User> userManager,
        IUnitOfWork unitOfWork,
        IUserImageService userImageService)
    {
        _userManager = userManager;
        _unitOfWork = unitOfWork;
        _userImageService = userImageService;
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
            Postcode = addressDto.Postcode,
            Country = addressDto.Country,
            Street = addressDto.Street,
            City = addressDto.City,
            PhoneNumber = addressDto.PhoneNumber
        };

        await _unitOfWork.Repository<Address>().AddAsync(address);
        await _unitOfWork.SaveChangesAsync();
        return address;
    }

    public async Task<Address> UpdateShippingAddressAsync(string userId, int addressId, ShippingAddressReqDto addressDto)
    {
        var address = await _unitOfWork.Repository<Address>().GetByIdAsync(addressId);
        if (address == null || address.UserId != userId)
            throw new NotFoundException("Address not found or not owned by user.");

        address.Name = addressDto.Name;
        address.Postcode = addressDto.Postcode;
        address.Country = addressDto.Country;
        address.Street = addressDto.Street;
        address.City = addressDto.City;
        address.PhoneNumber = addressDto.PhoneNumber;

        _unitOfWork.Repository<Address>().Update(address);
        await _unitOfWork.SaveChangesAsync();
        return address;
    }

    public async Task<bool> DeleteShippingAddressAsync(string userId, int addressId)
    {
        var address = await _unitOfWork.Repository<Address>().GetByIdAsync(addressId);
        if (address == null || address.UserId != userId)
            return false;

        _unitOfWork.Repository<Address>().Delete(address);
        return await _unitOfWork.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateProfileAsync(string userId, UpdateProfileReqDto profileDto)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) throw new UserNotFoundException(userId);

        user.FirstName = profileDto.FirstName;
        user.LastName = profileDto.LastName;
        user.Email = profileDto.Email;
        user.UserName = profileDto.Email; // Standard practice when email is used as username
        user.PhoneNumber = profileDto.PhoneNumber;

        var result = await _userManager.UpdateAsync(user);
        return result.Succeeded;
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

