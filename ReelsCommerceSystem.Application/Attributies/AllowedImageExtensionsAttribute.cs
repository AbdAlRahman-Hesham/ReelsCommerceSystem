using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ReelsCommerceSystem.Application.Attributies;

public class AllowedImageExtensionsAttribute : ValidationAttribute
{
    private readonly string[] _extensions = { ".jpg", ".jpeg", ".png", ".gif", ".webp" };

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var file = value as IFormFile;
        if (file == null)
            return ValidationResult.Success;

        var extension = Path.GetExtension(file.FileName)?.ToLower();
        if (string.IsNullOrEmpty(extension) || !_extensions.Contains(extension))
            return new ValidationResult("Only image files (.jpg, .jpeg, .png, .gif, .webp) are allowed.");

        if (!file.ContentType.StartsWith("image/"))
            return new ValidationResult("Invalid image file type.");

        return ValidationResult.Success;
    }
}
