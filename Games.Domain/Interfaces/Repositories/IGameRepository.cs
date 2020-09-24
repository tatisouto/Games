using Games.Domain.Models;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
   public  interface IGameRepository : IRepository<GameModel>
    {

        Task<GameModel> GetById(Guid id);      
        Task<IEnumerable<GameModel>> GetAll();

        Task<GameModel> GetByDescription(string description);

        void Add(GameModel game);
        void Update(GameModel game);
        void Remove(GameModel game);
    }
}
