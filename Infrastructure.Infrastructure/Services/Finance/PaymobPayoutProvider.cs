using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using ReelsCommerceSystem.Application.Interfaces.Services.Finance;

namespace ReelsCommerceSystem.Infrastructure.Services.Finance;

public class PaymobPayoutProvider : IPayoutProvider
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _username;
    private readonly string _password;

    public PaymobPayoutProvider(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _baseUrl = config["PaymobPayoutSettings:BaseUrl"] ?? "https://payouts.paymobsolutions.com/api/secure";
        _clientId = config["PaymobPayoutSettings:ClientId"]!;
        _clientSecret = config["PaymobPayoutSettings:ClientSecret"]!;
        _username = config["PaymobPayoutSettings:Username"]!;
        _password = config["PaymobPayoutSettings:Password"]!;
    }

    public async Task<PayoutResult> CreateTransferAsync(PayoutRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
            var token = await GetAccessTokenAsync(cancellationToken);
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var body = new Dictionary<string, object?>
            {
                ["issuer"] = request.Issuer,
                ["amount"] = request.Amount
            };

            if (!string.IsNullOrEmpty(request.Msisdn))
                body["msisdn"] = request.Msisdn;
            if (!string.IsNullOrEmpty(request.BankCardNumber))
                body["bank_card_number"] = request.BankCardNumber;
            if (!string.IsNullOrEmpty(request.BankCode))
                body["bank_code"] = request.BankCode;
            if (!string.IsNullOrEmpty(request.FullName))
                body["full_name"] = request.FullName;
            if (!string.IsNullOrEmpty(request.NationalId))
                body["national_id"] = request.NationalId;
            if (request.ClientReferenceId.HasValue)
                body["client_reference_id"] = request.ClientReferenceId.Value.ToString();
            if (!string.IsNullOrEmpty(request.ClientReference))
                body["client_reference"] = request.ClientReference;
            if (request.CustomerBearsFees)
                body["customer_bears_fees"] = true;

            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(
                $"{_baseUrl}/disburse/",
                content,
                cancellationToken);

            var rawResponse = await response.Content.ReadAsStringAsync(cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                return new PayoutResult
                {
                    Success = false,
                    StatusCode = ((int)response.StatusCode).ToString(),
                    StatusDescription = TryExtractErrorMessage(rawResponse),
                    RawResponse = rawResponse
                };
            }

            var result = JsonSerializer.Deserialize<PaymobDisburseResponse>(rawResponse);

            if (result == null)
            {
                return new PayoutResult
                {
                    Success = false,
                    StatusDescription = "Failed to parse Paymob response",
                    RawResponse = rawResponse
                };
            }

            var isSuccess = result.DisbursementStatus == "success";
            var isPending = result.DisbursementStatus == "pending";
            var isFailed = result.DisbursementStatus == "failed";

            return new PayoutResult
            {
                Success = isSuccess || isPending,
                TransactionId = result.TransactionId,
                DisbursementStatus = result.DisbursementStatus,
                StatusCode = result.StatusCode,
                StatusDescription = result.StatusDescription,
                RawResponse = rawResponse
            };
        }
        catch (Exception ex)
        {
            return new PayoutResult
            {
                Success = false,
                StatusDescription = ex.Message,
                RawResponse = ex.ToString()
            };
        }
    }

    public async Task<PayoutStatusResponse> CheckTransferStatusAsync(string transactionId, CancellationToken cancellationToken = default)
    {
        var token = await GetAccessTokenAsync(cancellationToken);
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", token);

        var body = new
        {
            transactions_ids_list = new[] { transactionId }
        };

        var json = JsonSerializer.Serialize(body);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(
            $"{_baseUrl}/transaction/inquire/",
            content,
            cancellationToken);

        var rawResponse = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                $"Paymob inquiry failed: {response.StatusCode} - {rawResponse}");
        }

        var inquiryResult = JsonSerializer.Deserialize<PaymobInquiryResponse>(rawResponse);

        var tx = inquiryResult?.Results?.FirstOrDefault();
        if (tx == null)
            throw new KeyNotFoundException($"Transaction {transactionId} not found in Paymob response");

        return new PayoutStatusResponse
        {
            TransactionId = tx.TransactionId,
            DisbursementStatus = tx.DisbursementStatus,
            StatusCode = tx.StatusCode,
            StatusDescription = tx.StatusDescription
        };
    }

    public Task<bool> CancelTransferAsync(string transferId, CancellationToken cancellationToken = default)
    {
        throw new NotSupportedException("Paymob Payouts API does not support cancel operation.");
    }

    private async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        var credentials = Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{_clientId}:{_clientSecret}"));

        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", credentials);

        var body = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("grant_type", "password"),
            new KeyValuePair<string, string>("username", _username),
            new KeyValuePair<string, string>("password", _password)
        });

        var response = await _httpClient.PostAsync(
            $"{_baseUrl}/o/token/",
            body,
            cancellationToken);

        var rawResponse = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
            throw new HttpRequestException(
                $"Paymob auth failed: {response.StatusCode} - {rawResponse}");

        var result = JsonSerializer.Deserialize<PaymobTokenResponse>(rawResponse);
        return result?.AccessToken
               ?? throw new InvalidOperationException("Failed to get Paymob access token");
    }

    private static string TryExtractErrorMessage(string rawResponse)
    {
        try
        {
            using var doc = JsonDocument.Parse(rawResponse);
            if (doc.RootElement.TryGetProperty("status_description", out var desc))
            {
                if (desc.ValueKind == JsonValueKind.String)
                    return desc.GetString()!;
                if (desc.ValueKind == JsonValueKind.Object)
                    return desc.ToString();
            }
            return rawResponse;
        }
        catch
        {
            return rawResponse;
        }
    }

    private class PaymobTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = null!;

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = null!;

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = null!;
    }

    private class PaymobDisburseResponse
    {
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = null!;

        [JsonPropertyName("disbursement_status")]
        public string DisbursementStatus { get; set; } = null!;

        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; } = null!;

        [JsonPropertyName("status_description")]
        public string StatusDescription { get; set; } = null!;
    }

    private class PaymobInquiryResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<PaymobInquiryResult>? Results { get; set; }
    }

    private class PaymobInquiryResult
    {
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = null!;

        [JsonPropertyName("disbursement_status")]
        public string DisbursementStatus { get; set; } = null!;

        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; } = null!;

        [JsonPropertyName("status_description")]
        public string StatusDescription { get; set; } = null!;
    }
}
