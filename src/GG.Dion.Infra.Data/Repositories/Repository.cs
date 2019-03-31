using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Repositories;
using GG.Dion.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GG.Dion.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepositoryRead<TEntity>, IRepositoryWrite<TEntity> where TEntity : Entity
    {
        private readonly DionProjectContext Db;
        private readonly DbSet<TEntity> DbSet;

        public Repository(DionProjectContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity);

            return entity;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetPaginateAsync(int skip, int take)
        {
            return await DbSet.Skip(skip).Take(take).ToListAsync();
        }

        public virtual async Task RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);

            await Task.CompletedTask;
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            var entry = Db.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;

            await Task.CompletedTask;
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
