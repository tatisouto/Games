using Games.Domain.Interfaces.Repositories;
using Games.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public async Task<TEntity> GetByIdAsync(Guid id) 
        {
            return await _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return (IEnumerable<TEntity>)_repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        TEntity IServiceBase<TEntity>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        //public void Dispose()
        //{
        //   // _repository.Dispose();
        //}
    }
}
