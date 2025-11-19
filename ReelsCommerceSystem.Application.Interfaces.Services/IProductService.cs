public interface IProductService
{
    Task<ApiResponse<PaginationResponse<GetAllProductsResponse>>> GetProductsAsync(ProductSpecParams productSpecParams);
    Task<ApiResponse<GetProductResponse>> GetProductAsync(int productId);
    Task<ApiResponse<List<ProductCategoryResponse>>> GetProductCategoriesAsync();
}