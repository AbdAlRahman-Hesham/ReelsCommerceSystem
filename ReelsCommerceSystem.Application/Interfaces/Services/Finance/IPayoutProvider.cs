namespace ReelsCommerceSystem.Application.Interfaces.Services.Finance;

public class PayoutRequest
{
    public string Issuer { get; init; } = null!;
    public decimal Amount { get; init; }
    public string? Msisdn { get; init; }
    public string? BankCardNumber { get; init; }
    public string? BankCode { get; init; }
    public string? FullName { get; init; }
    public string? NationalId { get; init; }
    public Guid? ClientReferenceId { get; init; }
    public string? ClientReference { get; init; }
    public bool CustomerBearsFees { get; init; }
}

public class PayoutResult
{
    public bool Success { get; init; }
    public string? TransactionId { get; init; }
    public string? DisbursementStatus { get; init; }
    public string? StatusCode { get; init; }
    public string? StatusDescription { get; init; }
    public string? RawResponse { get; init; }
}

public class PayoutStatusResponse
{
    public string TransactionId { get; init; } = null!;
    public string DisbursementStatus { get; init; } = null!;
    public string StatusCode { get; init; } = null!;
    public string StatusDescription { get; init; } = null!;
}

public interface IPayoutProvider
{
    Task<PayoutResult> CreateTransferAsync(PayoutRequest request, CancellationToken cancellationToken = default);
    Task<PayoutStatusResponse> CheckTransferStatusAsync(string transactionId, CancellationToken cancellationToken = default);
    Task<bool> CancelTransferAsync(string transferId, CancellationToken cancellationToken = default);
}
