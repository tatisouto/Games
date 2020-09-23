using Games.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
   public  interface IGameRepository : IRepository<Game>
    {

        Task<Game> GetById(Guid id);      
        Task<IEnumerable<Game>> GetAll();

        void Add(Game game);
        void Update(Game game);
        void Remove(Game game);
    }
}
