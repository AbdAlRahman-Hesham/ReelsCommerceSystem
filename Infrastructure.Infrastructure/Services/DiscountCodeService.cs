using ReelsCommerceSystem.Application.DTOs.Request.DiscountCode;
using ReelsCommerceSystem.Application.DTOs.Response.DiscountCode;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class DiscountCodeService(IUnitOfWork unitOfWork) : IDiscountCodeService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<IEnumerable<DiscountCodeResDto>> GetAllAsync()
    {
        var codes = await _unitOfWork.Repository<DiscountCode>().GetAllAsync();
        return codes.Select(MapToDto);
    }

    public async Task<DiscountCodeResDto?> GetByIdAsync(int id)
    {
        var code = await _unitOfWork.Repository<DiscountCode>().GetByIdAsync(id);
        return code == null ? null : MapToDto(code);
    }

    public async Task<DiscountCodeResDto> CreateAsync(DiscountCodeReqDto request)
    {
        if (request.DiscountValue > 50)
            throw new BadRequestException("Discount value cannot exceed 50%");

        var existing = await _unitOfWork.Repository<DiscountCode>()
            .FirstOrDefaultAsync(d => d.Code == request.Code);
            
        if (existing != null)
            throw new BadRequestException("Discount code already exists");

        var code = new DiscountCode
        {
            Code = request.Code,
            ExpirationDate = request.ExpirationDate,
            DiscountValue = request.DiscountValue,
            UsageCount = 0
        };

        await _unitOfWork.Repository<DiscountCode>().AddAsync(code);
        await _unitOfWork.SaveChangesAsync();

        return MapToDto(code);
    }

    public async Task<DiscountCodeResDto?> UpdateAsync(int id, DiscountCodeReqDto request)
    {
        if (request.DiscountValue > 50)
            throw new BadRequestException("Discount value cannot exceed 50%");

        var code = await _unitOfWork.Repository<DiscountCode>().GetByIdAsync(id);
        if (code == null) return null;

        code.Code = request.Code;
        code.ExpirationDate = request.ExpirationDate;
        code.DiscountValue = request.DiscountValue;

        _unitOfWork.Repository<DiscountCode>().Update(code);
        await _unitOfWork.SaveChangesAsync();

        return MapToDto(code);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var code = await _unitOfWork.Repository<DiscountCode>().GetByIdAsync(id);
        if (code == null) return false;

        _unitOfWork.Repository<DiscountCode>().Delete(code);
        return await _unitOfWork.SaveChangesAsync() > 0;
    }

    public async Task<DiscountCodeResDto?> VerifyDiscountCodeAsync(string code)
    {
        var discountCode = await _unitOfWork.Repository<DiscountCode>()
            .FirstOrDefaultAsync(d => d.Code == code);

        if (discountCode == null) return null;

        if (discountCode.ExpirationDate < DateTime.UtcNow)
            return null;

        return MapToDto(discountCode);
    }

    private static DiscountCodeResDto MapToDto(DiscountCode code) => new()
    {
        Id = code.Id,
        Code = code.Code,
        UsageCount = code.UsageCount,
        ExpirationDate = code.ExpirationDate,
        DiscountValue = code.DiscountValue
    };
}
