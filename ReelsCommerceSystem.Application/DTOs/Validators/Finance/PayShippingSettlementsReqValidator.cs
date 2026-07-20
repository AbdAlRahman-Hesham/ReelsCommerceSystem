using FluentValidation;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Finance;

public class PayShippingSettlementsReqValidator : AbstractValidator<PayShippingSettlementsReqDto>
{
    public PayShippingSettlementsReqValidator()
    {
        RuleFor(x => x.SettlementIds)
            .NotEmpty().WithMessage("At least one settlement ID is required");
    }
}
