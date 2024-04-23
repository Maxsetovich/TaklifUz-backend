using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces;
using TaklifUz.Domain.Entities;

namespace TaklifUz.DataAccess.Repositories;

public class GenericRepository<TEntity> : Repository<TEntity>,
    IGenericRepository<TEntity>
    where TEntity : BaseEntity
{
    public GenericRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }

    public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        => await _dbSet.FirstOrDefaultAsync(expression);

    public IQueryable<TEntity> GetAll() => _dbSet;

    public async Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        => await _dbSet.LastOrDefaultAsync(expression);

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        => _dbSet.Where(expression);
}
