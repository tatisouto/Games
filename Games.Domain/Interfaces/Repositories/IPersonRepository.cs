using Games.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
   public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetById(Guid id);
        Task<Person> GetByEmail(string email);
        Task<IEnumerable<Person>> GetAll();

        void Add(Person person);
        void Update(Person person);
        void Remove(Person person);
    }
}
