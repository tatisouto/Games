using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Games.Infra.Data.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected GamesContext Db;
        protected DbSet<TEntity> DbSet;


        public RepositoryBase(GamesContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
            
        }

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
    }
}
