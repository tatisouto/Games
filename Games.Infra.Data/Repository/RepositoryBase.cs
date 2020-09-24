using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Infra.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected readonly GamesContext Db;
        protected readonly DbSet<TEntity> DbSet;


        public RepositoryBase(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        //public async Task<TEntity> GetByEmail(string email)
        //{
        //    new NotImplementedException;
        //}

        public async Task<TEntity> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }
    }
}
