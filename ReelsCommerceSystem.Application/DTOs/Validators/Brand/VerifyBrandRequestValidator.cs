using FluentValidation;
using Microsoft.AspNetCore.Http;
using ReelsCommerceSystem.Application.DTOs.Request.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Application.DTOs.Validators.Brand
{
    public class VerifyBrandRequestValidator : AbstractValidator<VerifyBrandReq>
    {
        public VerifyBrandRequestValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full Name is required.")
                .Matches(@"^[A-Za-z\u0600-\u06FF\s]+$")
                .WithMessage("Full Name must contain letters only.");

            RuleFor(x => x.NationalId)
                .NotEmpty().WithMessage("National ID is required.")
                .Must(BeValidEgyptianNationalId)
                .WithMessage("National ID must be a valid Egyptian 14-digit number.");

            RuleFor(x => x.TaxNumber)
                .Must(BeValidTaxNumber)
                .When(x => !string.IsNullOrWhiteSpace(x.TaxNumber))
                .WithMessage("Tax Number is invalid.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone Number is required.");

            RuleFor(x => x.IdFrontImage)
                .NotNull().WithMessage("Front ID image is required.")
                .Must(BeValidFileSize).WithMessage("Front ID image must be <= 5MB.")
                .Must(BeValidImageType).WithMessage("Only JPG, PNG, WEBP images are allowed.");

            RuleFor(x => x.IdBackImage)
                .NotNull().WithMessage("Back ID image is required.")
                .Must(BeValidFileSize).WithMessage("Back ID image must be <= 5MB.")
                .Must(BeValidImageType).WithMessage("Only JPG, PNG, WEBP images are allowed.");

            RuleFor(x => x.SelfieImage)
                .NotNull().WithMessage("Selfie image is required.")
                .Must(BeValidFileSize).WithMessage("Selfie image must be <= 5MB.")
                .Must(BeValidImageType).WithMessage("Only JPG, PNG, WEBP images are allowed.");
        }

        private bool BeValidFileSize(IFormFile? file)
        {
            return file != null && file.Length <= 5 * 1024 * 1024;
        }

        private bool BeValidImageType(IFormFile? file)
        {
            if (file == null) return false;

            var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp" };
            return allowedTypes.Contains(file.ContentType);
        }

        private bool BeValidTaxNumber(string? taxNumber)
        {
            if (string.IsNullOrWhiteSpace(taxNumber)) return true;

            return Regex.IsMatch(taxNumber, @"^\d{9,15}$");
        }

        private bool BeValidEgyptianNationalId(string nationalId)
        {
            if (string.IsNullOrWhiteSpace(nationalId) || !Regex.IsMatch(nationalId, @"^\d{14}$"))
                return false;

            char century = nationalId[0];
            if (century != '2' && century != '3')
                return false;

            int year = int.Parse(nationalId.Substring(1, 2));
            int month = int.Parse(nationalId.Substring(3, 2));
            int day = int.Parse(nationalId.Substring(5, 2));

            int fullYear = century == '2' ? 1900 + year : 2000 + year;

            return DateTime.TryParse($"{fullYear}-{month:D2}-{day:D2}", out _);
        }
    }
}
