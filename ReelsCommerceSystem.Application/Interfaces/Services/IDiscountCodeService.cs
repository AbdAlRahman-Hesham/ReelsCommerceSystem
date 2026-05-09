using ReelsCommerceSystem.Application.DTOs.Request.DiscountCode;
using ReelsCommerceSystem.Application.DTOs.Response.DiscountCode;

namespace ReelsCommerceSystem.Application.Interfaces.Services;

public interface IDiscountCodeService
{
    Task<IEnumerable<DiscountCodeResDto>> GetAllAsync();
    Task<DiscountCodeResDto?> GetByIdAsync(int id);
    Task<DiscountCodeResDto> CreateAsync(DiscountCodeReqDto request);
    Task<DiscountCodeResDto?> UpdateAsync(int id, DiscountCodeReqDto request);
    Task<bool> DeleteAsync(int id);
    Task<DiscountCodeResDto?> VerifyDiscountCodeAsync(string code);
}
