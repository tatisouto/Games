
using Games.Domain.Entities;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
   public interface IGameLendRepository : IRepository<GameLend>
    {
        Task<GameLend> GetById(Guid id);      
        Task<IEnumerable<GameLend>> GetAll();

        void Add(GameLend gameLend);
        void Update(GameLend gameLend);
        void Remove(GameLend gameLend);
    }
}
