using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System.Security.Cryptography;
using System.Text;

namespace ReelsCommerceSystem.Api.Controllers;

public class PaymobWebhookController : AppBaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<PaymobWebhookController> _logger;
    private readonly INotificationService _notificationService;
    private readonly IFinanceService _financeService;
    private readonly string _paymobHmacSecret;
    private readonly string _redirectUrl;

    public PaymobWebhookController(IUnitOfWork unitOfWork, IConfiguration config, ILogger<PaymobWebhookController> logger, INotificationService notificationService, IFinanceService financeService)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _notificationService = notificationService;
        _paymobHmacSecret = config["PaymobSettings:HmacSecret"]!;
        _redirectUrl = config["PaymobSettings:RedirectUrl"]!;
        _financeService = financeService;

    }


    [HttpGet("payment")]
    public async Task<IActionResult> HandlePayment(CancellationToken cancellationToken)
    {
        // Get HMAC from query string
        var sentHmac = Request.Query["hmac"].ToString();

        if (string.IsNullOrEmpty(sentHmac))
        {
            return BadRequest("Missing HMAC");
        }

        var query = Request.Query;
        
        var id = long.Parse(query["id"].ToString() ?? "0");
        var pending = bool.Parse(query["pending"].ToString() ?? "false");
        var amountCents = long.Parse(query["amount_cents"].ToString() ?? "0");
        var success = bool.Parse(query["success"].ToString() ?? "false");
        var isSuccess = success;
        var isAuth = bool.Parse(query["is_auth"].ToString() ?? "false");
        var isCapture = bool.Parse(query["is_capture"].ToString() ?? "false");
        var isStandalonePayment = bool.Parse(query["is_standalone_payment"].ToString() ?? "false");
        var isVoided = bool.Parse(query["is_voided"].ToString() ?? "false");
        var isRefunded = bool.Parse(query["is_refunded"].ToString() ?? "false");
        var is3dSecure = bool.Parse(query["is_3d_secure"].ToString() ?? "false");
        var paymobOrderId = int.Parse(query["order"].ToString() ?? "0");
        var owner = int.Parse(query["owner"].ToString() ?? "0");
        var createdAt = query["created_at"].ToString() ?? "";
        var currency = query["currency"].ToString() ?? "";
        var errorOccurred = bool.Parse(query["error_occured"].ToString() ?? "false");
        var hasParentTransaction = bool.Parse(query["has_parent_transaction"].ToString() ?? "false");
        var integrationId = long.Parse(query["integration_id"].ToString() ?? "0");
        var profileId = long.Parse(query["profile_id"].ToString() ?? "0");
        var sourceDataType = query["source_data.type"].ToString() ?? "";
        var sourceDataPan = query["source_data.pan"].ToString() ?? "";
        var sourceDataSubType = query["source_data.sub_type"].ToString() ?? "";

        // Build concatenated string in EXACT order from docs using query parameters

        var concatenatedString =
            amountCents.ToString() +
            createdAt +
            currency +
            errorOccurred.ToString().ToLower() +
            hasParentTransaction.ToString().ToLower() +
            id.ToString() +
            integrationId.ToString() +
            is3dSecure.ToString().ToLower() +
            isAuth.ToString().ToLower() +
            isCapture.ToString().ToLower() +
            isRefunded.ToString().ToLower() +
            isStandalonePayment.ToString().ToLower() +
            isVoided.ToString().ToLower() +
            paymobOrderId.ToString() +
            owner.ToString() +
            pending.ToString().ToLower() +
            sourceDataPan +
            sourceDataSubType +
            sourceDataType +
            success.ToString().ToLower();

        //  Compute HMAC SHA512
        var secretBytes = Encoding.UTF8.GetBytes(_paymobHmacSecret);
        using var hmac = new HMACSHA512(secretBytes);
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(concatenatedString));
        var computedHmac = BitConverter.ToString(hash).Replace("-", "").ToLower();

        if (!CryptographicOperations.FixedTimeEquals(
                Encoding.UTF8.GetBytes(computedHmac),
                Encoding.UTF8.GetBytes(sentHmac.ToLower())))
        {
            return BadRequest("Invalid HMAC");
        }


        long orderId = paymobOrderId;
        long transactionId = id;
        bool isPending = pending;




        var orderRepo = _unitOfWork.Repository<Order>();
        var specification = new Specification<Order>(criteria: o => o.PaymobOrderId == orderId);
        var order = await orderRepo.GetWithSpecAsync(specification);
        
        if(order is null)
        {
            _logger.LogWarning("Received Paymob webhook for order ID {OrderId} which was not found in the system.", orderId);
            return NotFound($"Order with Paymob Order ID {orderId} not found.");
        }

        if (isSuccess)
        {
            order.PaymentStatus = PaymentStatus.Paid;
            _logger.LogInformation("Payment successful for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
        }
        else if (isPending)
        {
            order.PaymentStatus = PaymentStatus.Pending;
            _logger.LogInformation("Payment pending for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
        }
        else if (isVoided)
        {
            order.PaymentStatus = PaymentStatus.Voided;
            _logger.LogInformation("Payment voided for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
        }
        else if (isRefunded)
        {
            order.PaymentStatus = PaymentStatus.Refunded;
            _logger.LogInformation("Payment refunded for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
        }
        else
        {
           order.PaymentStatus = PaymentStatus.Failed;
            _logger.LogInformation("Payment failed for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
        }
        orderRepo.Update(order);
        var res = await _unitOfWork.SaveChangesAsync();

        if (res <= 0)
        {
            _logger.LogError("Failed to update payment status for order ID {OrderId}. Transaction ID: {TransactionId}", orderId, transactionId);
            return StatusCode(500, "Failed to update order payment status.");
        }

        // Send Notification
        await _notificationService.SendPaymentNotificationAsync(order, order.PaymentStatus);

        if (order.PaymentStatus == PaymentStatus.Paid)
        {
            await _financeService.CalculateAndCreateSettlementsAsync(order.Id);
        }

        return Ok();
    }

    [HttpGet("redirect")]
    public IActionResult HandleRedirect()
    {
        return Redirect(_redirectUrl);
    }
}
