namespace ReelsCommerceSystem.Domain.Enums.Finance;

public enum SettlementStatus
{
    Pending,
    ReadyForWithdrawal,
    WithdrawalRequested,
    TransferInitiated,
    Processing,
    Paid,
    Failed
}
