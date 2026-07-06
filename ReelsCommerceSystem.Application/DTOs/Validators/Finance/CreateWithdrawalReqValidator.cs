using FluentValidation;
using ReelsCommerceSystem.Application.DTOs.Request.Finance;
using ReelsCommerceSystem.Domain.Services.Finance;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Finance;

public class CreateWithdrawalReqValidator : AbstractValidator<CreateWithdrawalReqDto>
{
    public CreateWithdrawalReqValidator()
    {
        RuleFor(x => x.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than zero")
            .GreaterThanOrEqualTo(FinancialCalculator.MinimumWithdrawalAmount)
            .WithMessage($"Minimum withdrawal amount is {FinancialCalculator.MinimumWithdrawalAmount}");
    }
}
