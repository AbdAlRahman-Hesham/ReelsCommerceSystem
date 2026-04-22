using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Request.UserProfile;
using ReelsCommerceSystem.Application.DTOs.Response.UserProfile;
using ReelsCommerceSystem.Domain.Entities.UserEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IUserProfileService
{
    Task<List<Address>> GetShippingAddressesAsync(string userId);
    Task<Address> AddShippingAddressAsync(string userId, ShippingAddressReqDto addressDto);
    Task<Address> UpdateShippingAddressAsync(string userId, int addressId, UpdateShippingAddressDto addressDto);
    Task<bool> DeleteShippingAddressAsync(string userId, int addressId);
    Task<UpdateProfileResDto> UpdateProfileAsync(string userId, UpdateProfileReqDto profileDto);
    Task<bool> UpdatePasswordAsync(string userId, UpdatePasswordReqDto passwordDto);
    Task<bool> UpdateProfileImageAsync(string userId, IFormFile image);
    Task<bool> DeleteAccountAsync(string userId);
}
