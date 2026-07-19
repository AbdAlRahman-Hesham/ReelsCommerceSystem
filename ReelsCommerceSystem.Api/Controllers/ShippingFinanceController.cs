using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Shared.Exceptions;
using ReelsCommerceSystem.Shared.Responses;
using ReelsCommerceSystem.Shared.Utilities;
using System.Net;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/shipping/finance")]
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
        /*var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (userId == null) throw new UnauthorizedException("User is not authenticated");

        var company = _context.ShippingCompanies.Find(1);
        return company?.Id ?? throw new UnauthorizedException("User is not associated with a shipping company");*/
        return 1; // Placeholder for demonstration purposes
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
