
using System.Linq.Expressions;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    public Task<IReadOnlyList<T>> GetAllAsync();
    public Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification);

    public Task<T?> GetByIdAsync(int id);
    public Task<T?> GetWithSpecAsync(ISpecification<T> specification);

    public Task AddAsync(T entity);
    public void Update(T entity);
    public void Delete(T entity);

    public Task<int> SaveChangesAsync();
    public Task<int> CountAsync(ISpecification<T> specification);
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetAllQueryable();



}
