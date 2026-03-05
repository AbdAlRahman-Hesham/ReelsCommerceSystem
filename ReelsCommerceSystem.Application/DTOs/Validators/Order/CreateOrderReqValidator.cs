using FluentValidation;
using ReelsCommerceSystem.Application.DTOs.Request.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Order
{
    public class CreateOrderReqValidator : AbstractValidator<CreateOrderReq>
    {
        public CreateOrderReqValidator()
        {
            RuleFor(req => req.DeliveryMethod).IsInEnum();
            RuleFor(req => req.PaymentMethod).IsInEnum();

            RuleFor(req => req)
                .Must(req => req.AddressId.HasValue || req.Address != null)
                .WithMessage("Either AddressId or manual Address must be provided.");

            When(req => req.Address != null, () =>
            {
                RuleFor(req => req.Address.City).NotEmpty();
                RuleFor(req => req.Address.Country).NotEmpty();
                RuleFor(req => req.Address.Street).NotEmpty();
                RuleFor(req => req.Address.PostalCode).NotEmpty();
                RuleFor(req => req.Address.PhoneNumber).NotEmpty();
                RuleFor(req => req.Address.Name).NotEmpty();
            });
        }
    }
}
