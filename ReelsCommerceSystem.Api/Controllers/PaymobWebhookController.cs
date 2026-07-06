using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;
using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

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


    [HttpPost("payment")]
    public async Task<IActionResult> HandlePayment(CancellationToken cancellationToken)
    {
        // Get HMAC from query string
        var sentHmac = Request.Query["hmac"].ToString();

        if (string.IsNullOrEmpty(sentHmac))
        {
            return BadRequest("Missing HMAC");
        }

        Request.EnableBuffering();

        using var reader = new StreamReader(
            Request.Body,
            Encoding.UTF8,
            leaveOpen: true);

        var bodyContent = await reader.ReadToEndAsync(cancellationToken);
        Request.Body.Position = 0;

        var json = JsonDocument.Parse(bodyContent);
        var obj = json.RootElement.GetProperty("obj");

        // Build concatenated string in EXACT order from docs

        var concatenatedString =
            obj.GetProperty("amount_cents").GetInt64().ToString() +
            obj.GetProperty("created_at").GetString() +
            obj.GetProperty("currency").GetString() +
            obj.GetProperty("error_occured").GetBoolean().ToString().ToLower() +
            obj.GetProperty("has_parent_transaction").GetBoolean().ToString().ToLower() +
            obj.GetProperty("id").GetInt64().ToString() +
            obj.GetProperty("integration_id").GetInt64().ToString() +
            obj.GetProperty("is_3d_secure").GetBoolean().ToString().ToLower() +
            obj.GetProperty("is_auth").GetBoolean().ToString().ToLower() +
            obj.GetProperty("is_capture").GetBoolean().ToString().ToLower() +
            obj.GetProperty("is_refunded").GetBoolean().ToString().ToLower() +
            obj.GetProperty("is_standalone_payment").GetBoolean().ToString().ToLower() +
            obj.GetProperty("is_voided").GetBoolean().ToString().ToLower() +
            obj.GetProperty("order").GetProperty("id").GetInt64().ToString() +
            obj.GetProperty("owner").GetInt64().ToString() +
            obj.GetProperty("pending").GetBoolean().ToString().ToLower() +
            obj.GetProperty("source_data").GetProperty("pan").GetString() +
            obj.GetProperty("source_data").GetProperty("sub_type").GetString() +
            obj.GetProperty("source_data").GetProperty("type").GetString() +
            obj.GetProperty("success").GetBoolean().ToString().ToLower();

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

        bool isSuccess = obj.GetProperty("success").GetBoolean();
        bool isPending = obj.GetProperty("pending").GetBoolean();
        bool isRefunded = obj.GetProperty("is_refunded").GetBoolean();
        bool isCaptured = obj.GetProperty("is_capture").GetBoolean();
        bool isVoided = obj.GetProperty("is_voided").GetBoolean();
        long orderId = obj.GetProperty("order").GetProperty("id").GetInt64();
        long transactionId = obj.GetProperty("id").GetInt64();




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
