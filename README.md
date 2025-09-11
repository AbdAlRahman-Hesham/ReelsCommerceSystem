# 🚀 ReelsCommerceSystem – Team Guidelines & Project Structure

## 📋 Overview
This document serves as the **contribution guide** for developers working on **ReelsCommerceSystem**. It explains the project structure, naming conventions, repository/service patterns, GitHub rules, and API response format.

---

## 📂 Project Structure

```
ReelsCommerceSystem/
├── Api/
│   ├── Controllers/
│   ├── DependencyInjectionExtensions/
│   ├── Endpoints/
│   ├── Middlewares/
│   ├── Resources/
│   ├── Validators/
│   ├── appsettings.json
│   └── Program.cs
├── Infrastructure/
│   ├── Persistence/
│   ├── Repositories/
│   ├── Services/
│   ├── Specifications/
│   └── ReelsCommerceSystem.Infrastructure.csproj
├── Application/
│   ├── Attributies/
│   ├── DTOs/
│   ├── Interfaces/
│   └── ReelsCommerceSystem.Application.csproj
├── Domain/
│   ├── Common/
│   ├── Entities/
│   ├── Enums/
│   └── ReelsCommerceSystem.Domain.csproj
├── Shared/
│   ├── Exceptions/
│   ├── Responses/
│   ├── Utilities/
│   └── ReelsCommerceSystem.Shared.csproj
├── .gitignore
├── README.md
└── ReelsCommerceSystem.sln
```

---

## 📝 Naming Conventions

- **Entities** → Singular (`Product`, `User`, `Order`)
- **DTOs** → `{Action}{Entity}{Req|Res}` (e.g., `AddProductReq`, `AddProductRes`)
- **Controllers** → Plural (`ProductsController`, `UsersController`)
- **Repositories** → `IGenericRepository<T>`, `IBrandRepository`
- **Specifications** → `{Entity}Spec` (e.g., `ProductSpec`)
- **Migrations** → `yyyyMMddHHmmss_Description`

---

## ⚙️ Generic Repository & Specification Pattern

### 📌 Generic Repository
- Provides **common data access** methods (CRUD)
- Located in: `Infrastructure/Repositories/GenericRepository.cs`

```csharp
public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> spec);
    Task<T?> GetWithSpecAsync(ISpecification<T> spec);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}
```

### 📌 Specification Pattern
- Encapsulates query logic
- Located in: `Infrastructure/Specifications/Common/`

```csharp
public class ProductSpec : Specification<Product>
{
    public ProductSpec(ProductSpecParams specParams)
        : base(x =>
            (string.IsNullOrEmpty(specParams.Search) || x.Name.Contains(specParams.Search))
            && (!specParams.BrandId.HasValue || x.BrandId == specParams.BrandId))
    {
        AddInclude(x => x.Brand);
        ApplyPaging(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);
    }
}
```

---

## 📚 Using the Specification & Pagination Pattern

### 1️⃣ Create Specification Params
Every entity that supports filtering, sorting, and pagination needs a SpecParams class.

```csharp
public class ProductSpecParams
{
    private const int MaxPageSize = 50;

    public int PageIndex { get; set; } = 1;
    private int _pageSize = 10;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }

    public string? Search { get; set; }
    public int? BrandId { get; set; }
    public string? Sort { get; set; }
    public bool IsAscending { get; set; } = true;
}
```

➡️ This defines pagination inputs, plus filters like Search, BrandId, and sorting via Sort.

### 2️⃣ Inherit from Specification<T>
Specifications wrap query logic so repositories remain generic.

```csharp
public class ProductSpec : Specification<Product>
{
    public ProductSpec(ProductSpecParams specParams)
        : base(x =>
            (string.IsNullOrEmpty(specParams.Search) || x.Name.Contains(specParams.Search)) &&
            (!specParams.BrandId.HasValue || x.BrandId == specParams.BrandId))
    {
        // Eager load related Brand
        AddInclude(x => x.Brand);

        // Sorting
        if (!string.IsNullOrEmpty(specParams.Sort))
        {
            switch (specParams.Sort.ToLower())
            {
                case "priceasc":
                    AddOrderBy(p => p.Price);
                    break;
                case "pricedesc":
                    AddOrderByDescending(p => p.Price);
                    break;
                default:
                    AddOrderBy(p => p.Name);
                    break;
            }
        }
        else
        {
            AddOrderBy(p => p.Name);
        }

        // Pagination (convert to 0-based index)
        ApplyPaging(specParams.PageIndex - 1, specParams.PageSize);
    }
}
```

🔑 Key points:
- **Criteria** → Where filters live
- **AddInclude** → For Include (EF eager loading)
- **OrderBy / OrderByDescending** → Sorting
- **ApplyPaging** → Skip/Take applied later in evaluator

### 3️⃣ Repository Usage
Since GenericRepository<T> is wired with SpecificationEvaluator<T>, you can pass a spec directly.

```csharp
var spec = new ProductSpec(specParams);
var products = await _productRepository.GetAllWithSpecAsync(spec);
var totalCount = spec.GetCount(_context.Products);
```

### 4️⃣ Pagination Response
Use PaginationResponse<T> to wrap paged data consistently.

```csharp
var totalCount = await spec.GetCountAsync(_context.Products);
var meta = new Meta
{
    PageNumber = specParams.PageIndex,
    PageSize = specParams.PageSize,
    TotalRecords = totalCount,
    HasPreviousPage = spec.HasPreviousPage(),
    HasNextPage = spec.HasNextPage(totalCount)
};

return PaginationResponse<ProductDto>.SuccessResponse(
    _mapper.Map<List<ProductDto>>(products),
    meta,
    HttpStatusCode.OK
);
```

✅ Always return Meta + Data.

### 5️⃣ Controller Example
```csharp
[HttpGet]
public async Task<IActionResult> GetProducts([FromQuery] ProductSpecParams specParams)
{
    var spec = new ProductSpec(specParams);

    var products = await _productRepository.GetAllWithSpecAsync(spec);
    var totalCount = await spec.GetCountAsync(_context.Products);

    var meta = new Meta
    {
        PageNumber = specParams.PageIndex,
        PageSize = specParams.PageSize,
        TotalRecords = totalCount,
        HasPreviousPage = spec.HasPreviousPage(),
        HasNextPage = spec.HasNextPage(totalCount)
    };

    return Ok(PaginationResponse<ProductDto>.SuccessResponse(
        _mapper.Map<List<ProductDto>>(products),
        meta,
        HttpStatusCode.OK
    ));
}
```

### 6️⃣ Inheriting GenericRepository<T>
If you need an entity-specific repository (e.g., ProductRepository):

```csharp
public interface IProductRepository : IGenericRepository<Product>
{
    Task<Product?> GetProductWithBrandAsync(long id);
}

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Product?> GetProductWithBrandAsync(long id)
    {
        return await _context.Products
            .Include(p => p.Brand)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}
```

➡️ Use generic methods for 80% of cases, and create specific repos only when needed.

---

## 🏁 Summary for Team

1. **Step 1**: Create `{Entity}SpecParams` for filtering/pagination
2. **Step 2**: Create `{Entity}Spec` inheriting `Specification<T>`
3. **Step 3**: Use in repository (`GetAllWithSpecAsync`)
4. **Step 4**: Return `PaginationResponse<T>` with Meta info
5. **Step 5**: Inherit `GenericRepository<T>` only for custom queries

---

## 🏗️ Workflow – From Entity to Controller

1. **Create a new Entity**
   - Add under `Domain/Entities/`
   - Inherit from `BaseEntity`

2. **Add DTOs**
   - Request DTO → `Application/DTOs/Request/{Entity}/`
   - Response DTO → `Application/DTOs/Response/{Entity}/`

3. **Add Repository Interface**
   - In `Application/Interfaces/Repositories/`

4. **Add Service Interface + Implementation**
   - Interface → `Application/Interfaces/Services/`
   - Implementation → `Infrastructure/Services/`

5. **Register Repository & Service**
   - Inside `Api/DependencyInjectionExtensions/RegisterRepositoriesExtension.cs`

6. **Add Controller**
   - Create in `Api/Controllers/{Entity}Controller.cs`
   - Use constructor injection with `IGenericRepository<T>` or specific service

```csharp
[ApiController]
[Route("api/[controller]")]
public class ProductsController : AppBaseController
{
    private readonly IBrandService _brandService;

    public ProductsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _brandService.GetAllAsync();
        return Ok(ApiResponse.Success(result));
    }
}
```

---

## 🌱 GitHub Workflow

### 📌 Branch Naming
- **Feature** → `Feature/task-1-create-car`
- **Bug Fix** → `Fix/bug-1-car-instance-null-exception`

### 📌 Commit Messages
**Adding**
```
- Add handler
- Add repository
- Add contract
- Add migrations
```

**Deleting**
```
- Remove DTO file
```

**Editing**
```
- Update AddService in Repository
```

### 📌 Branch Rules
- `master` → Production (Restricted)
- `staging` → Pre-production (Read-only)
- `development` → Main integration branch (all team commits)
- Personal branches → per developer

### 📌 Contribution Process
1. Clone repo OR pull development branch
2. Create personal branch → `Feature/...` or `Bug/...`
3. Commit small changes frequently
4. Checkout development, pull latest
5. Merge development → personal branch
6. Push changes
7. Create Pull Request (PR)
8. Repeat cycle

---

## 🌍 Generic API Response Format (English & Arabic)

```json
{
  "success": true,
  "statusCode": 200,
  "message": {
    "en": "Request completed successfully.",
    "ar": "تم تنفيذ الطلب بنجاح."
  },
  "data": null,
  "errors": null
}
```

✅ **Supported codes**: 200, 201, 204, 400, 401, 403, 404, 500

📖 See detailed examples in `Shared/Responses/ApiResponse.cs`

---

## 🎯 Summary

- Follow naming conventions
- Use GenericRepository + Specification for queries
- Always register repos & services in DI extensions
- Follow GitHub branching & commit rules
- API must return standardized JSON responses

---
