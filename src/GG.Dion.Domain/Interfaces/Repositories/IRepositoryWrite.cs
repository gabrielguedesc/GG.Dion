using GG.Dion.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace GG.Dion.Domain.Interfaces.Repositories
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}
