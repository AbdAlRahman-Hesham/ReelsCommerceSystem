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


*Last Updated: {Current Date}*  
*Maintained by: Development Team*
