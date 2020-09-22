using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{

    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);
        
        Task<IEnumerable<TEntity>> GetAll();

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }

}

