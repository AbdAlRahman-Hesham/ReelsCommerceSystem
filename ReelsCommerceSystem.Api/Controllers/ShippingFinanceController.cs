using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/shipping/finance")]
[Authorize(Roles = SystemRoles.BrandOwner)]
public class ShippingFinanceController : AppBaseController
{
    private readonly IFinanceService _financeService;
    private readonly AppDbContext _context;

    public ShippingFinanceController(IFinanceService financeService, AppDbContext context)
    {
        _financeService = financeService;
        _context = context;
    }

    private async Task<int> GetCurrentShippingCompanyIdAsync()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) throw new UnauthorizedAccessException();

        var company = _context.ShippingCompanies.FirstOrDefault(c => c.UserId == userId);
        return company?.Id ?? throw new UnauthorizedAccessException("User is not associated with a shipping company");
    }

    [HttpGet("summary")]
    public async Task<IActionResult> GetSummary()
    {
        var companyId = await GetCurrentShippingCompanyIdAsync();
        var data = await _financeService.GetShippingWalletSummaryAsync(companyId);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("settlements")]
    public async Task<IActionResult> GetSettlements([FromQuery] SettlementFilterDto filter)
    {
        var companyId = await GetCurrentShippingCompanyIdAsync();
        var data = await _financeService.GetShippingSettlementsAsync(companyId, filter);
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }

    [HttpGet("policy")]
    public async Task<IActionResult> GetPolicy()
    {
        var data = await _financeService.GetShippingPolicyAsync();
        return Ok(ApiResponse<object>.SuccessResponse(data, HttpStatusCode.OK));
    }
}
