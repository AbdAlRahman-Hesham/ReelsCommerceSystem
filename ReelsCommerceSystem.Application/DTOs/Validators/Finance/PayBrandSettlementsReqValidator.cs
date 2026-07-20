using FluentValidation;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Finance;

public class PayBrandSettlementsReqValidator : AbstractValidator<PayBrandSettlementsReqDto>
{
    public PayBrandSettlementsReqValidator()
    {
        RuleFor(x => x)
            .Must(x => (x.SettlementIds != null && x.SettlementIds.Count > 0) || x.WithdrawalRequestId.HasValue)
            .WithMessage("Either settlement IDs or withdrawal request ID must be provided");
    }
}
