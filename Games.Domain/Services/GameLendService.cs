using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Domain.Interfaces.Services;

namespace Games.Domain.Services
{
    public class GameLendService : ServiceBase<GameLend>, IGameLendService
    {

        private readonly IGameLendRepository _gameLendRepository;

        public GameLendService(IGameLendRepository gameLendRepository) : base(gameLendRepository)
        {
            _gameLendRepository = gameLendRepository;
        }
    }
}

