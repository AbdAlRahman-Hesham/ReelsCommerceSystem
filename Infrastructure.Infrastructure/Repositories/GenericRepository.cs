using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;

namespace ReelsCommerceSystem.Infrastructure.Repositories;


public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();



    #region Query Methods
    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification)
    {
        return await SpecificationEvaluator<T>
            .GetQuery(_dbSet.AsQueryable(), specification)
            .ToListAsync();
    }

    public async Task<T?> GetByIdAsync(long id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T?> GetWithSpecAsync(ISpecification<T> specification)
    {
        return await SpecificationEvaluator<T>
            .GetQuery(_dbSet.AsQueryable(), specification)
            .FirstOrDefaultAsync();
    }
    #endregion

    #region Write Methods
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<int> SaveChangesAsync()
    {
       return await _context.SaveChangesAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }
    #endregion
    public async Task<int> CountAsync(ISpecification<T> specification)
    {
        return await SpecificationEvaluator<T>
            .GetQuery(_dbSet.AsQueryable(), specification, false)
            .CountAsync();
    }

}
