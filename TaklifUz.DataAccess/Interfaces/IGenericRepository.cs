using System.Linq.Expressions;
using TaklifUz.Domain.Entities;

namespace TaklifUz.DataAccess.Interfaces;

public interface IGenericRepository<TEntity> : IRepository<TEntity> 
    where TEntity : BaseEntity
{
    public IQueryable<TEntity> GetAll();

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);

    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);

    public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
}
