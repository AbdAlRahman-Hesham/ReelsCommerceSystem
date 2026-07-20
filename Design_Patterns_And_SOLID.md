# Design Patterns and SOLID Principles

## 1. SOLID Compliance Analysis

### 1.1 Single Responsibility Principle (SRP)

Each class in the system has a clearly defined responsibility:

- **Controllers** — Handle HTTP request/response concerns only; delegate business logic to services.
- **Services** — Contain business logic and orchestration; operate exclusively through interface abstractions.
- **Repositories** — Manage data access and query execution for a single aggregate root.
- **Specifications** — Encapsulate query logic (criteria, includes, sorting, paging) for a single entity type.
- **Middlewares** — Handle cross-cutting concerns (exception handling, validation, logging) independently.

Example: `OrderService` (`Infrastructure/Services/OrderService.cs`) orchestrates cart retrieval, discount validation, order creation, and payment initiation but delegates actual data access to `GenericRepository<T>` and external calls to `IPaymobService`.

### 1.2 Open/Closed Principle (OCP)

The system is open for extension but closed for modification through:

- **Specification Pattern** — New query requirements are implemented by creating new `Specification<T>` subclasses without modifying existing repositories or services. Over 60 specification classes exist across 8 subfolders.
- **Generic Repository** — `GenericRepository<T>` provides standard CRUD operations for any `BaseEntity` without modification. Custom query behaviour is added through specifications rather than repository inheritance.
- **Service Registration** — The `RegisterRepositoriesExtention` scans assemblies for `*Service` classes and auto-registers them, allowing new services to be added without modifying DI registration code.

### 1.3 Liskov Substitution Principle (LSP)

- All service implementations conform to their interfaces (`IAuthenticationService`, `IOrderService`, etc.), ensuring they can be substituted without affecting consumers.
- Specification logical operators (`&`, `|`, `!`) return new `Specification<T>` instances (`AndSpecification<T>`, `OrSpecification<T>`, `NotSpecification<T>`) that extend the base class and satisfy the `ISpecification<T>` contract.
- The `GenericRepository<T>` implements `IGenericRepository<T>` with only `where T : BaseEntity`, allowing any entity to be used polymorphically.

### 1.4 Interface Segregation Principle (ISP)

The Application layer defines 40+ fine-grained service interfaces:

```
IAuthenticationService    → Login, Register, CheckEmail, SignOut
ICartService             → GetUserCart, AddToCart, UpdateCart
IOrderService            → CreateOrder, GetOrders, GetOrderDetails, CancelOrder
IReelFeedService         → GetForYouFeed, GetFollowingFeed, GetReelsByIds
IChatRoomService         → CreateRoom, GetUserRooms, GetRoomRes, GetUnreadCount, DeleteRoom
IChatService             → SendMessage, GetMessages, DeleteMessage, DeleteAllMessages
```

Each interface defines a cohesive set of operations. No client is forced to depend on methods it does not use.

### 1.5 Dependency Inversion Principle (DIP)

All layer dependencies point to abstractions:

- **Controllers** depend on service interfaces (e.g., `IBrandService`, `IOrderService`), not concrete implementations.
- **Services** depend on repository interfaces (`IGenericRepository<T>`, `IUnitOfWork`) and other service interfaces.
- **Infrastructure** implements interfaces defined in the Application layer, never the reverse.
- The composition root (`Program.cs`) is the only place where concrete types are wired to abstractions via DI.

## 2. Design Patterns

### 2.1 Generic Repository Pattern

**Location:** `Infrastructure/Repositories/GenericRepository.cs`

The `GenericRepository<T>` abstracts common data access operations:

| Method | Description |
|---|---|
| `GetAllAsync()` | Retrieves all entities |
| `GetByIdAsync(int id)` | Retrieves by primary key |
| `GetAllWithSpecAsync(ISpecification<T>)` | Retrieves with specification (filtering, includes, sorting, paging) |
| `GetWithSpecAsync(ISpecification<T>)` | Retrieves single entity with specification |
| `AddAsync(T entity)` | Inserts entity |
| `Update(T entity)` | Marks entity as modified |
| `Delete(T entity)` | Marks entity for deletion |
| `CountAsync(ISpecification<T>)` | Counts entities matching specification |
| `FirstOrDefaultAsync(Expression<Func<T, bool>>)` | Retrieves first match by predicate |

Custom repository interfaces (e.g., `IDiscountCodeRepository`, `IProductRepository`) extend `IGenericRepository<T>` only when additional query methods are needed.

### 2.2 Specification Pattern

**Location:** `Infrastructure/Specifications/Common/Specification.cs` and `SpecificationEvaluator.cs`

The `Specification<T>` base class encapsulates query logic into reusable, composable units:

```csharp
public class ProductSpec : Specification<Product>
{
    public ProductSpec(ProductSpecParams specParams)
    {
        // Criteria: WHERE clause
        AddCriteria(p => p.BrandId == brandId && ...);
        
        // Includes: eager loading
        AddInclude(p => p.Brand);
        AddInclude("AvailableColors.ProductColor");
        
        // Sorting
        AddOrderByDescending(p => p.Price);
        
        // Paging
        ApplyPaging(pageIndex, pageSize);
        
        // Query modifiers
        AsSplitQuery();
    }
}
```

The `SpecificationEvaluator<T>` applies the specification to an `IQueryable<T>` by composing: Criteria → Include → IncludeString → IncludeChain → OrderBy → Skip/Take → QueryModifiers.

**Composition Support:** Specifications support Boolean algebra via operator overloading:
```csharp
var activeProducts = new ActiveProductsSpec();
var discountedProducts = new DiscountedProductsSpec();
var activeAndDiscounted = activeProducts & discountedProducts; // AND
var activeOrDiscounted = activeProducts | discountedProducts;  // OR
var notActive = !activeProducts;                                 // NOT
```

### 2.3 Unit of Work Pattern

**Location:** `Infrastructure/UnitOfWorks/UnitOfWork.cs`

The `UnitOfWork` class coordinates changes across multiple repositories within a single database transaction:

```csharp
public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    private readonly Hashtable _repositories = new();

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
    {
        // Creates or retrieves cached GenericRepository<TEntity>
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
```

The pattern ensures that multiple repository operations are committed atomically. Repositories are cached in a `Hashtable` keyed by entity type name, providing efficient reuse within a single unit of work scope.

### 2.4 Dependency Injection Pattern

The system uses the built-in ASP.NET Core DI container as the composition root. All dependencies are injected via constructor injection with three lifetimes:

- **Scoped** — Most services and repositories: `services.AddScoped<IProductService, ProductService>()`
- **Transient** — Not used explicitly; auto-registration defaults to scoped
- **Singleton** — `Cloudinary` client, `IMemoryCache`

The `RegisterAllServices` method in `RegisterRepositoriesExtention.cs` uses assembly scanning to automatically register all service implementations:
```csharp
var serviceTypes = assembly.GetTypes()
    .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service") && ...);
foreach (var implType in serviceTypes)
{
    var interfaceType = implType.GetInterface("I" + implType.Name);
    if (interfaceType != null)
        services.AddScoped(interfaceType, implType);
}
```

### 2.5 Middleware Pattern

Custom middleware classes encapsulate cross-cutting concerns in the HTTP pipeline:

- **`ExceptionHandlingMiddleware`** — Catches unhandled exceptions and returns standardised API responses with bilingual messages and appropriate HTTP status codes.
- **`ValidationActionFilter`** — Implements `IActionFilter` to intercept invalid `ModelState` before action execution.

### 2.6 Strategy Pattern (via Specifications)

The Specification pattern is a form of Strategy pattern where query strategies are encapsulated as specification objects. The `SpecificationEvaluator<T>` acts as the context that applies the strategy to an `IQueryable<T>`. This allows the query logic to vary independently from the classes that use it.

### 2.7 Adapter Pattern

The `ChatSender` and `NotificationRealtimeSender` classes in the Api layer implement Application-layer interfaces (`IChatSender`, `INotificationRealtimeSender`) and adapt SignalR's `IHubContext<THub>` to the application's abstraction layer. This keeps the Application layer completely unaware of SignalR.

### 2.8 Facade Pattern

Service classes act as facades over complex subsystem interactions:
- `OrderService` coordinates `CartService`, `DiscountCodeService`, `PaymentService`, and repository operations.
- `BrandProductService` orchestrates product CRUD with Cloudinary image management and specification-based querying.

### 2.9 Builder Pattern (Fluent Configuration)

The `Specification<T>` class uses a fluent builder API:
```csharp
new ProductSpec()
    .AddCriteria(p => p.Price > 10)
    .AddInclude(p => p.Brand)
    .AddOrderBy(p => p.Name)
    .ApplyPaging(1, 20);
```

DI extension methods also follow the builder pattern:
```csharp
builder.Services
    .AddApplicationDBConfig(builder.Configuration)
    .AddRepositoriesAndServices()
    .AddAppAuthenticationServices(builder.Configuration)
    .AddApplicationCorsConfig(builder.Configuration);
```

## 3. Additional Architectural Patterns

### 3.1 Auto-Registration Pattern

Services are automatically registered via assembly scanning based on naming convention (`IServiceName` ↔ `ServiceName`). Three services are excluded explicitly (`RecommendationService`, `PaymobService`, `GeminiTranslationService`) because they are registered separately with `HttpClient` factory.

### 3.2 Owned Entity Pattern (EF Core)

The `Otp` value object is configured as an owned entity of `User` using EF Core's owned entity support:
```csharp
modelBuilder.Entity<User>(b =>
{
    b.OwnsOne(u => u.Otp);
});
```

### 3.3 Query Object Pattern

Specification parameter classes (e.g., `ProductSpecParams`, `GetBrandProductsParams`, `GetCommunityPostsReq`) encapsulate all query inputs including filters, sorting, and pagination. These are used directly by controllers as `[FromQuery]` parameters and passed to specification constructors.

### 3.4 Data Transfer Object (DTO) Pattern

The Application layer defines separate DTO classes for request and response payloads, organised by module:
- `Application/DTOs/Request/{Module}/{Action}{Entity}Req`
- `Application/DTOs/Response/{Module}/{Action}{Entity}Res`

This ensures that internal entity structures are never exposed outside the Application boundary.
