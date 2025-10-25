using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Specifications.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReelsCommerceSystem.Infrastructure.Repositories
{
    public class CartGenericRepository<T>(CartDbContext context) : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly CartDbContext _context = context;
        protected readonly DbSet<T> _dbSet = context.Set<T>();

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

        public async Task<T?> GetByIdAsync(int id)
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
        #endregion
    }

}

