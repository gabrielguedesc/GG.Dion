using GG.Dion.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace GG.Dion.Domain.Interfaces.Repositories
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> RemoveAsync(TEntity entity);
    }
}
