using System.Linq.Expressions;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification);

    Task<T?> GetByIdAsync(int id);
    Task<T?> GetWithSpecAsync(ISpecification<T> specification);

    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task<int> SaveChangesAsync();
    Task<int> CountAsync(ISpecification<T> specification);
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetAllQueryable();
    Task AddRangeAsync(IEnumerable<T> entities);
    Task DeleteRangeAsync(IEnumerable<T> entities);
}
