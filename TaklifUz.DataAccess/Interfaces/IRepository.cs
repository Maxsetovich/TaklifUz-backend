using TaklifUz.Domain.Entities;

namespace TaklifUz.DataAccess.Interfaces;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    public Task<long> CountAsync();
    public void Add(TEntity entity);
    public void Update(long id, TEntity editedEntity);
    public void Delete(TEntity entity);
    public Task<TEntity?> GetByIdAsync(long id);
}
