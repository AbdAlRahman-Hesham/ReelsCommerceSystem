using ReelsCommerceSystem.Application.Interfaces.Repositories;
using ReelsCommerceSystem.Domain.Common;
using ReelsCommerceSystem.Domain.Entities.CartEntities;
using ReelsCommerceSystem.Infrastructure.Persistence;
using ReelsCommerceSystem.Infrastructure.Repositories;
using System.Collections;

namespace ReelsCommerceSystem.Infrastructure.UnitOfWorks;

public class UnitOfWork(AppDbContext context, CartDbContext cartDbContext) : IUnitOfWork
{
    private readonly AppDbContext _context = context;
    private readonly CartDbContext _cartDbContext = cartDbContext;
    private readonly Hashtable _repositories = new Hashtable();

    public async Task<int> SaveChangesAsync()
    {
        await _cartDbContext.SaveChangesAsync();
        return await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
    {
        var type = typeof(TEntity).Name;
        if (!_repositories.ContainsKey(type))
        {
            object repositoryInstance;


            if (typeof(TEntity) == typeof(Cart))
            {
                repositoryInstance = new CartRepository(_cartDbContext);
            }
            else
            {
                var repositoryType = typeof(GenericRepository<>);
                repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
            }

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<TEntity>)_repositories[type]!;
    }
}


public interface IUnitOfWork : IAsyncDisposable
{
    IGenericRepository<T> Repository<T>() where T : BaseEntity;
    public Task<int> SaveChangesAsync();
}
