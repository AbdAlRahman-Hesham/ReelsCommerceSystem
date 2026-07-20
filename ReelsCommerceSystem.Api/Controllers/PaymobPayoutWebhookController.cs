using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using ReelsCommerceSystem.Domain.Entities.FinanceEntities;
using ReelsCommerceSystem.Domain.Enums.Finance;
using ReelsCommerceSystem.Infrastructure.Persistence;
using System.Text.Json;

namespace ReelsCommerceSystem.Api.Controllers;

[Route("api/paymob-webhook")]
[ApiController]
public class PaymobPayoutWebhookController : AppBaseController
{
    private readonly AppDbContext _context;
    private readonly IFinancialAuditLogRepository _auditLogRepo;
    private readonly ILogger<PaymobPayoutWebhookController> _logger;

    public PaymobPayoutWebhookController(
        AppDbContext context,
        IFinancialAuditLogRepository auditLogRepo,
        ILogger<PaymobPayoutWebhookController> logger)
    {
        _context = context;
        _auditLogRepo = auditLogRepo;
        _logger = logger;
    }

    [HttpPost("payout")]
    public async Task<IActionResult> HandlePayoutCallback()
    {
        string rawBody;
        using (var reader = new StreamReader(Request.Body))
        {
            rawBody = await reader.ReadToEndAsync();
        }

        _logger.LogInformation("Received payout callback: {Body}", rawBody);

        PaymobCallbackPayload? payload;
        try
        {
            payload = JsonSerializer.Deserialize<PaymobCallbackPayload>(rawBody);
        }
        catch
        {
            return BadRequest("Invalid JSON payload");
        }

        if (payload == null || string.IsNullOrEmpty(payload.TransactionId))
            return BadRequest("Missing transaction_id");

        var settlement = _context.BrandSettlements
            .FirstOrDefault(s => s.TransferId == payload.TransactionId);

        if (settlement == null)
        {
            _logger.LogWarning("No settlement found for transfer {TransferId}", payload.TransactionId);
            return Ok();
        }

        switch (payload.DisbursementStatus)
        {
            case "success":
                settlement.Status = SettlementStatus.Paid;
                settlement.PaidAt = DateTime.UtcNow;
                settlement.PaymentReference = payload.TransactionId;
                break;
            case "failed":
                settlement.RetryCount++;
                settlement.Status = SettlementStatus.Failed;
                settlement.Notes = $"Paymob callback: {payload.StatusDescription}";
                break;
            default:
                _logger.LogInformation("Transfer {TransferId} status: {Status}",
                    payload.TransactionId, payload.DisbursementStatus);
                return Ok();
        }

        _context.BrandSettlements.Update(settlement);
        await _context.SaveChangesAsync();

        await _auditLogRepo.AddAsync(new FinancialAuditLog
        {
            Action = $"PayoutCallback_{payload.DisbursementStatus}",
            EntityType = "BrandSettlement",
            EntityId = settlement.Id,
            NewValues = rawBody,
            PerformedBy = "Paymob",
            Notes = $"Payout callback received for transfer {payload.TransactionId}"
        });

        _logger.LogInformation(
            "Settlement {SettlementId} updated to {Status} from payout callback",
            settlement.Id, settlement.Status);

        return Ok();
    }

    private class PaymobCallbackPayload
    {
        public string TransactionId { get; set; } = null!;
        public string DisbursementStatus { get; set; } = null!;
        public string StatusCode { get; set; } = null!;
        public string StatusDescription { get; set; } = null!;
    }
}
