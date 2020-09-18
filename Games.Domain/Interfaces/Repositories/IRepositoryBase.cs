using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Domain.Interfaces.Repositories
{

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        void Dispose();
        int SaveChanges();
    }

}

