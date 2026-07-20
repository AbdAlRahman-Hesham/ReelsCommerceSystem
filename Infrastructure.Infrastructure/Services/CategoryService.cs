using ReelsCommerceSystem.Application.DTOs.Request.Category;
using ReelsCommerceSystem.Application.DTOs.Response.Product;
using ReelsCommerceSystem.Application.Interfaces.Services;
using ReelsCommerceSystem.Domain.Entities.ProductEntites;
using ReelsCommerceSystem.Infrastructure.UnitOfWorks;
using ReelsCommerceSystem.Shared.Exceptions;

namespace ReelsCommerceSystem.Infrastructure.Services;

public class CategoryService(IUnitOfWork unitOfWork, IPhotoServive photoService) : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IPhotoServive _photoService = photoService;

    public async Task<IEnumerable<ProductCategoryResponse>> GetAllAsync()
    {
        var categories = await _unitOfWork.Repository<ProductCategory>().GetAllAsync();
        return categories.Select(MapToDto);
    }

    public async Task<ProductCategoryResponse?> GetByIdAsync(int id)
    {
        var category = await _unitOfWork.Repository<ProductCategory>().GetByIdAsync(id);
        return category == null ? null : MapToDto(category);
    }

    public async Task<ProductCategoryResponse> CreateAsync(CategoryReqDto request)
    {
        var existing = await _unitOfWork.Repository<ProductCategory>()
            .FirstOrDefaultAsync(c => c.Name == request.Name);

        if (existing != null)
            throw new BadRequestException("Category name already exists");

        var category = new ProductCategory
        {
            Name = request.Name,
            ArName = request.ArName,
            ImageUrl = request.ImageUrl,
            ImagePublicId = request.ImagePublicId
        };

        await _unitOfWork.Repository<ProductCategory>().AddAsync(category);
        await _unitOfWork.SaveChangesAsync();

        return MapToDto(category);
    }

    public async Task<ProductCategoryResponse?> UpdateAsync(int id, CategoryReqDto request)
    {
        var category = await _unitOfWork.Repository<ProductCategory>().GetByIdAsync(id);
        if (category == null) return null;

        var oldPublicId = category.ImagePublicId;

        category.Name = request.Name;
        category.ArName = request.ArName;
        category.ImageUrl = request.ImageUrl;
        category.ImagePublicId = request.ImagePublicId;

        _unitOfWork.Repository<ProductCategory>().Update(category);
        await _unitOfWork.SaveChangesAsync();

        if (!string.IsNullOrWhiteSpace(oldPublicId))
        {
            await _photoService.DeleteImageAsync(oldPublicId);
        }

        return MapToDto(category);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var category = await _unitOfWork.Repository<ProductCategory>().GetByIdAsync(id);
        if (category == null) return false;

        if (!string.IsNullOrWhiteSpace(category.ImagePublicId))
        {
            await _photoService.DeleteImageAsync(category.ImagePublicId);
        }

        _unitOfWork.Repository<ProductCategory>().Delete(category);
        return await _unitOfWork.SaveChangesAsync() > 0;
    }

    private static ProductCategoryResponse MapToDto(ProductCategory category) => new()
    {
        Id = category.Id,
        Name = category.Name,
        ArName = category.ArName,
        ImageUrl = category.ImageUrl
    };
}
