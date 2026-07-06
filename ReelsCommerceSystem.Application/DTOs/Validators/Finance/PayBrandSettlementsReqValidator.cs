using FluentValidation;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Finance;

public class PayBrandSettlementsReqValidator : AbstractValidator<PayBrandSettlementsReqDto>
{
    public PayBrandSettlementsReqValidator()
    {
        RuleFor(x => x.SettlementIds)
            .NotEmpty().WithMessage("At least one settlement ID is required")
            .Must((req, ids) => ids.Count > 0 || req.WithdrawalRequestId.HasValue)
            .WithMessage("Either settlement IDs or withdrawal request ID must be provided");
    }
}
