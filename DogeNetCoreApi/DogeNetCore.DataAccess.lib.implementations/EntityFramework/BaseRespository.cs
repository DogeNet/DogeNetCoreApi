using DogeNetCore.DataAccess.lib.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogeNetCore.DataAccess.lib.implementations.EntityFramework
{
    public class BaseRespository<TEntity, TContext, TKey> : IRepository<TEntity,TKey> where TEntity : class, IEntity<TKey> where TContext : DbContext
    {
        protected readonly TContext Context;

        public BaseRespository(TContext context)
        {
            Context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<TEntity> FindAsync(TKey key)
        {
            var query = from entity in Context.Set<TEntity>()
                         where entity.Key.Equals(key)
                         select entity;
            return await query.FirstAsync();           
        }

        public Task<IQueryable<TEntity>> FindAsync(IEnumerable<string> keys)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<TEntity>> GetAll()
        {
            return Task.FromResult<IQueryable<TEntity>>(Context.Set<TEntity>());
        }

        public async Task RemoveAsync(TEntity entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
