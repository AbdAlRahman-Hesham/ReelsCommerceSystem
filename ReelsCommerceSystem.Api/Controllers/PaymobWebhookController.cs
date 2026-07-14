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

    public PaymobWebhookController(IUnitOfWork unitOfWork, IConfiguration config, ILogger<PaymobWebhookController> logger, INotificationService notificationService, IFinanceService financeService)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _notificationService = notificationService;
        _paymobHmacSecret = config["PaymobSettings:HmacSecret"]!;
        _financeService = financeService;
    }

    [HttpGet("payment")]
    public async Task<IActionResult> HandlePayment(CancellationToken cancellationToken)
    {
        try
        {
            var sentHmac = Request.Query["hmac"].ToString();

            if (string.IsNullOrEmpty(sentHmac))
            {
                return Content(PaymentPageHtml("failed", 0, 0, 0, "Missing payment verification token"), "text/html");
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

            var secretBytes = Encoding.UTF8.GetBytes(_paymobHmacSecret);
            using var hmac = new HMACSHA512(secretBytes);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(concatenatedString));
            var computedHmac = BitConverter.ToString(hash).Replace("-", "").ToLower();

            if (!CryptographicOperations.FixedTimeEquals(
                    Encoding.UTF8.GetBytes(computedHmac),
                    Encoding.UTF8.GetBytes(sentHmac.ToLower())))
            {
                return Content(PaymentPageHtml("failed", 0, 0, 0, "Payment verification failed. Invalid signature."), "text/html");
            }

            long orderId = paymobOrderId;
            long transactionId = id;
            bool isPending = pending;

            var orderRepo = _unitOfWork.Repository<Order>();
            var specification = new Specification<Order>(criteria: o => o.PaymobOrderId == orderId);
            var order = await orderRepo.GetWithSpecAsync(specification);

            if (order is null)
            {
                _logger.LogWarning("Received Paymob webhook for order ID {OrderId} which was not found in the system.", orderId);
                return Content(PaymentPageHtml("failed", orderId, transactionId, amountCents / 100m, "Order not found in the system."), "text/html");
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
                return Content(PaymentPageHtml("failed", orderId, transactionId, order.TotalAmount, "Failed to update order payment status. Please contact support."), "text/html");
            }

            await _notificationService.SendPaymentNotificationAsync(order, order.PaymentStatus);

            if (order.PaymentStatus == PaymentStatus.Paid)
            {
                await _financeService.CalculateAndCreateSettlementsAsync(order);
            }

            var statusKey = order.PaymentStatus switch
            {
                PaymentStatus.Paid => "success",
                PaymentStatus.Pending => "pending",
                PaymentStatus.Voided => "voided",
                PaymentStatus.Refunded => "refunded",
                _ => "failed"
            };

            return Content(PaymentPageHtml(statusKey, orderId, transactionId, order.TotalAmount), "text/html");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error in HandlePayment webhook");
            return Content(PaymentPageHtml("error", 0, 0, 0, "An unexpected error occurred. Please try again later."), "text/html");
        }
    }

    private static string PaymentPageHtml(string status, long orderId, long transactionId, decimal amount, string? customMessage = null)
    {
        var (iconSvg, title, subtitle, color, btnText, btnLink) = status switch
        {
            "success" => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#10B981"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#10B981""/>
                    <path d=""M28 41L36 49L52 33"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                  </svg>",
                "Payment Successful!",
                "Your payment has been processed successfully. Your order is being prepared.",
                "#10B981",
                "Continue Shopping",
                "/"
            ),
            "pending" => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#F59E0B"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#F59E0B""/>
                    <path d=""M40 24V40L50 46"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                    <circle cx=""40"" cy=""40"" r=""18"" stroke=""white"" stroke-width=""3"" fill=""none""/>
                  </svg>",
                "Payment Pending",
                "Your payment is being processed. This usually takes just a few moments.",
                "#F59E0B",
                "Back to Home",
                "/"
            ),
            "failed" => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#EF4444"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#EF4444""/>
                    <path d=""M30 30L50 50M50 30L30 50"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                  </svg>",
                "Payment Failed",
                customMessage ?? "Your payment could not be processed. Please try again or use a different payment method.",
                "#EF4444",
                "Try Again",
                "/checkout"
            ),
            "voided" => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#FE6239"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#FE6239""/>
                    <path d=""M28 28L52 52M52 28L28 52"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                    <circle cx=""40"" cy=""40"" r=""18"" stroke=""white"" stroke-width=""3"" fill=""none""/>
                  </svg>",
                "Payment Voided",
                "This payment has been voided. If you believe this is an error, please contact support.",
                "#FE6239",
                "Back to Home",
                "/"
            ),
            "refunded" => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#4A90E2"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#4A90E2""/>
                    <path d=""M46 28L34 40L46 52"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                  </svg>",
                "Payment Refunded",
                "Your payment has been refunded. The amount will be returned to your account within 3-5 business days.",
                "#4A90E2",
                "Back to Home",
                "/"
            ),
            _ => (
                @"<svg width=""80"" height=""80"" viewBox=""0 0 80 80"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <circle cx=""40"" cy=""40"" r=""40"" fill=""#EF4444"" opacity=""0.1""/>
                    <circle cx=""40"" cy=""40"" r=""28"" fill=""#EF4444""/>
                    <path d=""M40 24V44M40 52V54"" stroke=""white"" stroke-width=""4"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                    <circle cx=""40"" cy=""40"" r=""18"" stroke=""white"" stroke-width=""3"" fill=""none""/>
                  </svg>",
                "Something Went Wrong",
                customMessage ?? "An unexpected error occurred. Please try again later.",
                "#EF4444",
                "Try Again",
                "/checkout"
            )
        };

        decimal displayAmount = amount;
        string orderDisplayId = orderId > 0 ? orderId.ToString() : "---";
        string transactionDisplayId = transactionId > 0 ? transactionId.ToString() : "---";
        string amountDisplay = displayAmount > 0 ? $"{displayAmount:F2} EGP" : "---";
        bool showDetails = orderId > 0;

        return $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Payment {(status == "success" ? "Successful" : status == "pending" ? "Pending" : "Failed")} - Alluvo</title>
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Cinzel+Decorative:wght@400;700&family=Inter:wght@400;500;600;700&family=Poppins:wght@300;400;500;600;700&display=swap"" rel=""stylesheet"">
    <style>
        * {{ margin: 0; padding: 0; box-sizing: border-box; }}
        html, body {{
            height: 100%;
            font-family: 'Inter', Arial, sans-serif;
            background: #F6F3EC;
            color: #111827;
            line-height: 1.5;
            -webkit-font-smoothing: antialiased;
        }}
        body {{
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            padding: 16px;
        }}
        .card {{
            background: #FEFEFE;
            border-radius: 16px;
            padding: 40px 32px;
            width: 100%;
            max-width: 520px;
            box-shadow: 0px 4px 15px rgba(0, 0, 0, 0.05);
            text-align: center;
            animation: fadeIn 0.3s ease-out;
        }}
        @keyframes fadeIn {{
            from {{ opacity: 0; transform: translateY(8px); }}
            to {{ opacity: 1; transform: translateY(0); }}
        }}
        .logo {{
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
            margin-bottom: 32px;
        }}
        .logo-text {{
            font-family: 'Cinzel Decorative', serif;
            font-size: 24px;
            font-weight: 400;
            background: linear-gradient(90deg, #1B2351 0%, #47C0D2 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            text-shadow: 0px 4px 4px rgba(0,0,0,0.25);
        }}
        .icon {{ margin-bottom: 24px; }}
        .title {{
            font-family: 'Poppins', sans-serif;
            font-size: 28px;
            font-weight: 600;
            color: #383644;
            margin-bottom: 8px;
        }}
        .subtitle {{
            font-size: 16px;
            color: #535456;
            margin-bottom: 32px;
            padding: 0 8px;
        }}
        .details {{
            background: #F6F3EC;
            border-radius: 12px;
            padding: 20px 24px;
            margin-bottom: 32px;
            text-align: left;
        }}
        .detail-row {{
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 8px 0;
        }}
        .detail-row:not(:last-child) {{
            border-bottom: 1px solid #D2D3D4;
        }}
        .detail-label {{
            font-size: 14px;
            font-weight: 500;
            color: #1B2351;
        }}
        .detail-value {{
            font-size: 14px;
            font-weight: 600;
            color: #383644;
        }}
        .btn {{
            display: inline-flex;
            align-items: center;
            justify-content: center;
            width: 100%;
            height: 48px;
            padding: 0 24px;
            border: none;
            border-radius: 8px;
            font-family: 'Inter', sans-serif;
            font-size: 16px;
            font-weight: 500;
            color: #FEFEFE;
            background: linear-gradient(90deg, #1B2351 0%, #47C0D2 100%);
            box-shadow: 0px 4px 4px 0px rgba(0,0,0,0.25);
            cursor: pointer;
            text-decoration: none;
            transition: opacity 0.2s;
        }}
        .btn:hover {{ opacity: 0.9; }}
        .btn:active {{ box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.25); }}
        .error-page .btn {{ background: linear-gradient(90deg, #EF4444 0%, #892727 100%); }}

        @media (max-width: 600px) {{
            .card {{ padding: 32px 20px; border-radius: 12px; }}
            .title {{ font-size: 24px; }}
            .subtitle {{ font-size: 14px; }}
            .details {{ padding: 16px; }}
            .logo-text {{ font-size: 20px; }}
        }}
    </style>
</head>
<body>
    <div class=""card {(status == "error" || status == "failed" ? "error-page" : "")}"">
        <div class=""logo"">
            <span class=""logo-text"">Alluvo</span>
        </div>

        <div class=""icon"">{iconSvg}</div>

        <h1 class=""title"" style=""color: {color}"">{title}</h1>
        <p class=""subtitle"">{subtitle}</p>

        {(showDetails ? $@"
        <div class=""details"">
            <div class=""detail-row"">
                <span class=""detail-label"">Order ID</span>
                <span class=""detail-value"">#{orderDisplayId}</span>
            </div>
            <div class=""detail-row"">
                <span class=""detail-label"">Transaction ID</span>
                <span class=""detail-value"">{transactionDisplayId}</span>
            </div>
            <div class=""detail-row"">
                <span class=""detail-label"">Amount</span>
                <span class=""detail-value"" style=""color:{color}"">{amountDisplay}</span>
            </div>
        </div>" : "")}

    </div>

    <script>
        function handleAction() {{
            if (window.opener && !window.opener.closed) {{
                window.opener.postMessage({{
                    type: 'PAYMENT_RESULT',
                    status: '{status}',
                    url: window.location.href,
                    orderId: {orderId},
                    transactionId: {transactionId},
                    amount: {amount}
                }}, '*');
                setTimeout(function() {{ window.close(); }}, 300);
            }} else if (window.parent && window.parent !== window) {{
                window.parent.postMessage({{
                    type: 'PAYMENT_RESULT',
                    status: '{status}',
                    url: window.location.href,
                    orderId: {orderId},
                    transactionId: {transactionId},
                    amount: {amount}
                }}, '*');
            }} else {{
                window.location.href = '{(status == "success" ? "/" : "/checkout")}';
            }}
        }}

        // Auto-notify if loaded in a popup window
        (function() {{
            if (window.opener && !window.opener.closed) {{
                window.opener.postMessage({{
                    type: 'PAYMENT_RESULT',
                    status: '{status}',
                    url: window.location.href,
                    orderId: {orderId},
                    transactionId: {transactionId},
                    amount: {amount}
                }}, '*');
            }}
        }})();
    </script>
</body>
</html>";
    }
}