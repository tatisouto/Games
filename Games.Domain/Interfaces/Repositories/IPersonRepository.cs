using Games.Domain.Models;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
   public interface IPersonRepository : IRepository<PersonModel>
    {
        Task<PersonModel> GetById(Guid id);
        Task<PersonModel> GetByEmail(string email);
        Task<IEnumerable<PersonModel>> GetAll();

        void Add(PersonModel person);
        void Update(PersonModel person);
        void Remove(PersonModel person);
    }
}
