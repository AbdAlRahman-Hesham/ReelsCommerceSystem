using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.BrandEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/brand/finance")]
[Authorize(Roles = SystemRoles.BrandOwner)]
public class BrandFinanceController : AppBaseController
{
    private readonly IFinanceService _financeService;
    private readonly AppDbContext _context;

    public BrandFinanceController(IFinanceService financeService, AppDbContext context)
    {
        _financeService = financeService;
        _context = context;
    }

    private async Task<int> GetCurrentBrandIdAsync()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) throw new UnauthorizedException("User is not authenticated");

        var brandEntity = await Task.FromResult(_context.Brands.FirstOrDefault(b => b.UserId == userId));
        return brandEntity?.Id ?? throw new UnauthorizedException("User is not associated with a brand");
    }

    [HttpGet("summary")]
    public async Task<IActionResult> GetSummary()
    {
        var brandId = await GetCurrentBrandIdAsync();
        var data = await _financeService.GetBrandWalletSummaryAsync(brandId);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("settlements")]
    public async Task<IActionResult> GetSettlements([FromQuery] SettlementFilterDto filter)
    {
        var brandId = await GetCurrentBrandIdAsync();
        var data = await _financeService.GetBrandSettlementsAsync(brandId, filter);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpPost("withdraw")]
    public async Task<IActionResult> CreateWithdrawal([FromBody] CreateWithdrawalReqDto request)
    {
        var brandId = await GetCurrentBrandIdAsync();
        var data = await _financeService.CreateWithdrawalRequestAsync(brandId, request);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK, "Withdrawal request created", "تم إنشاء طلب السحب"));
    }

    [HttpGet("withdrawals")]
    public async Task<IActionResult> GetWithdrawals()
    {
        var brandId = await GetCurrentBrandIdAsync();
        var data = await _financeService.GetBrandWithdrawalHistoryAsync(brandId);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("policy")]
    public async Task<IActionResult> GetPolicy()
    {
        var data = await _financeService.GetBrandPolicyAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }
}
