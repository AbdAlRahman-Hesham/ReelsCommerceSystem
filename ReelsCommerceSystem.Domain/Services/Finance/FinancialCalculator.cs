namespace ReelsCommerceSystem.Domain.Services.Finance;

public static class FinancialCalculator
{
    public const decimal PlatformCommissionRate = 0.01m;
    public const decimal BrandRate = 0.99m;
    public const decimal ShippingFeePerOrder = 60m;
    public const decimal MinimumWithdrawalAmount = 100m;

    public static (decimal Commission, decimal BrandAmount, decimal ShippingAmount) Calculate(
        decimal productSubtotal, decimal shippingFee)
    {
        var commission = Math.Round(productSubtotal * PlatformCommissionRate, 2);
        var brandAmount = Math.Round(productSubtotal - commission, 2);
        return (commission, brandAmount, ShippingFeePerOrder);
    }
}
