using Microsoft.EntityFrameworkCore;
using TaklifUz.DataAccess.DbContexts;
using TaklifUz.DataAccess.Interfaces;
using TaklifUz.Domain.Entities;

namespace TaklifUz.DataAccess.Repositories;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(AppDbContext appDbContext)
    {
        this._dbSet = appDbContext.Set<TEntity>();
    }

    public void Add(TEntity entity) => _dbSet.Add(entity);

    public void Delete(TEntity entity) => _dbSet.Remove(entity);

    public void Update(long id, TEntity editedEntity)
    {
        editedEntity.Id = id;
        _dbSet.Update(editedEntity);
    }

    public async Task<TEntity?> GetByIdAsync(long id)
        => await _dbSet.FindAsync(id);

    public async Task<long> CountAsync()
        => await _dbSet.CountAsync(); 
}
