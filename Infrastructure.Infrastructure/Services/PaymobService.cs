using Microsoft.Extensions.Configuration;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.OrderEntities;
using ReelsCommerceSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Services
{
    using ReelsCommerceSystem.Shared.Responses;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class PaymobService : IPaymobService
    {
        private readonly HttpClient _httpClient;
        private readonly int _cardIntegrationId;
        private readonly int _walletIntegrationId;
        private readonly string _apiKey;
        private readonly int _merchantId;
        private int _lastPaymobOrderId;
        private readonly int _iframeId;

        public PaymobService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _cardIntegrationId = config.GetValue<int>("PaymobSettings:CardIntegrationId");
            _walletIntegrationId = config.GetValue<int>("PaymobSettings:WalletIntegrationId");
            _apiKey = config.GetValue<string>("PaymobSettings:ApiKey")!;
            _merchantId = config.GetValue<int>("PaymobSettings:MerchantId");
            _iframeId = config.GetValue<int>("PaymobSettings:IframeId");

        }

        public async Task<ApiResponse<string>> CreatePaymentUrlAsync(Order order, PaymentMethod method)
        {
            try
            {
                if (order == null)
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest, "Order is null", "الطلب فارغ");

                if (order.User == null || string.IsNullOrEmpty(order.User.Email))
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest, "Order user or email is missing", "مستخدم الطلب أو البريد الإلكتروني مفقود");

                string firstName = order.ShippingName ?? "NA";
                string lastName = order.ShippingLastName ?? "NA";
                string email = order.User.Email;
                string phone = order.ShippingPhoneNumber ?? "01000000000";
                string city = order.ShippingCity ?? "Cairo";
                string country = order.ShippingCountry ?? "EG";

                // 1️⃣ Auth
                var authResponse = await _httpClient.PostAsJsonAsync(
                    "https://accept.paymob.com/api/auth/tokens",
                    new { api_key = _apiKey }
                );

                var authRaw = await authResponse.Content.ReadAsStringAsync();
                if (!authResponse.IsSuccessStatusCode)
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.InternalServerError, $"Auth failed: {authRaw}", $"فشل المصادقة: {authRaw}");

                var authData = JsonSerializer.Deserialize<PaymobAuthResponse>(authRaw);
                string authToken = authData!.Token;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);

                // 2️⃣ Create Order
                var paymobOrderResponse = await _httpClient.PostAsJsonAsync(
                    "https://accept.paymob.com/api/ecommerce/orders",
                    new
                    {
                        merchant_id = _merchantId,
                        amount_cents = (int)(order.TotalAmount * 100),
                        currency = "EGP"
                    }
                );

                var orderRaw = await paymobOrderResponse.Content.ReadAsStringAsync();
                if (!paymobOrderResponse.IsSuccessStatusCode)
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.InternalServerError, $"Order creation failed: {orderRaw}", $"فشل إنشاء الطلب: {orderRaw}");

                var orderData = JsonSerializer.Deserialize<PaymobOrderResponse>(orderRaw);

                // 3️⃣ Select IntegrationId
                int integrationId = method switch
                {
                    PaymentMethod.Card => _cardIntegrationId,
                    PaymentMethod.Wallet => _walletIntegrationId,
                    _ => throw new Exception("Invalid payment method")
                };

                // 4️⃣ Create Payment Key
                var paymentKeyResponse = await _httpClient.PostAsJsonAsync(
                    "https://accept.paymob.com/api/acceptance/payment_keys",
                    new
                    {
                        amount_cents = (int)(order.TotalAmount * 100),
                        currency = "EGP",
                        order_id = orderData!.Id,
                        billing_data = new
                        {
                            first_name = firstName,
                            last_name = lastName,
                            email = email,
                            phone_number = phone,
                            street = order.ShippingStreet ?? "NA",
                            building = order.ShippingBuilding ?? "NA",
                            floor = order.ShippingFloor ?? "NA",
                            apartment = order.ShippingApartment ?? "NA",
                            city = city,
                            state = "NA",
                            country = country,
                            postal_code = "12345"
                        },
                        integration_id = integrationId
                    }
                );

                var paymentKeyRaw = await paymentKeyResponse.Content.ReadAsStringAsync();
                if (!paymentKeyResponse.IsSuccessStatusCode)
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.InternalServerError, $"Payment key failed: {paymentKeyRaw}", $"فشل إنشاء مفتاح الدفع: {paymentKeyRaw}");

                var paymentKeyData = JsonSerializer.Deserialize<PaymobResponse>(paymentKeyRaw);
                string token = paymentKeyData!.Token;

                string paymentUrl;

                // 💳 CARD FLOW
                if (method == PaymentMethod.Card)
                {
                    paymentUrl = $"https://accept.paymob.com/api/acceptance/iframes/{_iframeId}?payment_token={token}";
                }
                // 📱 WALLET FLOW
                else if (method == PaymentMethod.Wallet)
                {
                    var walletResponse = await _httpClient.PostAsJsonAsync(
                        "https://accept.paymob.com/api/acceptance/payments/pay",
                        new
                        {
                            source = new
                            {
                                identifier = phone,
                                subtype = "WALLET"
                            },
                            payment_token = token
                        }
                    );

                    var walletRaw = await walletResponse.Content.ReadAsStringAsync();
                    if (!walletResponse.IsSuccessStatusCode)
                        return ApiResponse<string>.ErrorResponse(HttpStatusCode.InternalServerError, $"Wallet payment failed: {walletRaw}", $"فشل دفع المحفظة: {walletRaw}");

                    using var doc = JsonDocument.Parse(walletRaw);
                    paymentUrl = doc.RootElement.GetProperty("redirect_url").GetString()!;
                }
                else
                {
                    return ApiResponse<string>.ErrorResponse(HttpStatusCode.BadRequest, "Unhandled payment method", "طريقة الدفع غير مدعومة");
                }

                _lastPaymobOrderId = orderData!.Id;

                return ApiResponse<string>.SuccessResponse(paymentUrl, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ApiResponse<string>.ErrorResponse(HttpStatusCode.InternalServerError, ex.Message, ex.Message);
            }
        }

        public Task<int> GetLastCreatedOrderIdAsync() => Task.FromResult(_lastPaymobOrderId);

        private class PaymobResponse
        {
            [JsonPropertyName("token")]
            public string Token { get; set; } = default!;
        }

        private class PaymobAuthResponse
        {
            [JsonPropertyName("token")]
            public string Token { get; set; } = default!;
        }

        private class PaymobOrderResponse
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
        }
    }
}
