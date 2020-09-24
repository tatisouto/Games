
using Games.Domain.Models;
using NetDevPack.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Domain.Interfaces.Repositories
{
    public interface IGameLendRepository : IRepository<GameLendModel>
    {
        Task<GameLendModel> GetById(Guid id);
        Task<IEnumerable<GameLendModel>> GetAll();
        Task<GameLendModel> GetByGameId(Guid idGame);
        bool GameIsAvailable(Guid idGame);

        void Add(GameLendModel gameLend);
        void Update(GameLendModel gameLend);
        void Remove(GameLendModel gameLend);
    }
}
