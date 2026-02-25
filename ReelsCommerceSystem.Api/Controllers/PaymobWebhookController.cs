using Microsoft.AspNetCore.Mvc;
using ReelsCommerceSystem.Application.DTOs.Request.Payment;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using System.Security.Cryptography;
using System.Text;

namespace ReelsCommerceSystem.Api.Controllers
{
    public class PaymobWebhookController : AppBaseController
    {
            private readonly IUnitOfWork _unitOfWork;
            private readonly string _paymobHmacSecret;

            public PaymobWebhookController(IUnitOfWork unitOfWork, IConfiguration config)
            {
                _unitOfWork = unitOfWork;
                _paymobHmacSecret = config["PaymobSettings:HmacSecret"];     
            }
        [HttpPost("payment")]
        public async Task<IActionResult> HandlePayment([FromBody] PaymobWebhookDto webhook)
        {
           
            if (!Request.Headers.TryGetValue("X-Callback-Signature", out var sentHmac))
                return BadRequest("Missing HMAC header");

            
            Request.Body.Position = 0; 
            using var reader = new StreamReader(Request.Body);
            var bodyContent = await reader.ReadToEndAsync();

            var secretBytes = Encoding.UTF8.GetBytes(_paymobHmacSecret);
            using var hmacsha512 = new HMACSHA512(secretBytes);
            var computedHmac = hmacsha512.ComputeHash(Encoding.UTF8.GetBytes(bodyContent));
            var computedHmacString = BitConverter.ToString(computedHmac).Replace("-", "").ToLower();

            if (computedHmacString != sentHmac.ToString().ToLower())
                return BadRequest("Invalid HMAC signature");

            
            var order = await _unitOfWork.Repository<Order>().GetByIdAsync(webhook.OrderId);
            if (order == null)
                return NotFound();

            
            switch (webhook.PaymentStatus.ToLower())
            {
                case "paid":
                    order.PaymentStatus = PaymentStatus.Paid;
                    order.OrderStatus = OrderStatus.Processing;
                    break;

                case "failed":
                    order.PaymentStatus = PaymentStatus.Failed;
                    break;

                case "refunded":
                    order.PaymentStatus = PaymentStatus.Refunded;
                    order.OrderStatus = OrderStatus.Cancelled;
                    break;

                default:
                    return BadRequest("Unknown payment status");
            }

            await _unitOfWork.SaveChangesAsync();

            return Ok();      
        }
    }
}
