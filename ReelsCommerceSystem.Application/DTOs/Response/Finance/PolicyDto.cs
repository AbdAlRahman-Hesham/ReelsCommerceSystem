namespace ReelsCommerceSystem.Application.DTOs.Response.Finance;

public class BrandPolicyDto
{
    public decimal PlatformCommissionPercentage { get; set; }
    public decimal MinimumWithdrawalAmount { get; set; }
    public string WithdrawalRules { get; set; } = null!;
    public string SettlementConditions { get; set; } = null!;
    public string WithdrawalProcessingTime { get; set; } = null!;
    public string PaymentProvider { get; set; } = null!;
    public string SupportContact { get; set; } = null!;
}

public class ShippingPolicyDto
{
    public string PaymentSchedule { get; set; } = null!;
    public string SettlementRules { get; set; } = null!;
    public string DeliveryRequirements { get; set; } = null!;
    public string PaymentProcessingTime { get; set; } = null!;
    public string SupportedPaymentMethod { get; set; } = null!;
    public string SupportContact { get; set; } = null!;
}

public class AdminPolicyDto
{
    public decimal CurrentCommission { get; set; }
    public string SettlementWorkflow { get; set; } = null!;
    public string WithdrawalWorkflow { get; set; } = null!;
    public string ShippingWorkflow { get; set; } = null!;
}
