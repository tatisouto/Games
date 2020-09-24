using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Domain.Interfaces.Services;

namespace Games.Domain.Services
{
    public class GameService : ServiceBase<Game>, IGameService
    {
        private readonly IGameRepository _gameRepository;
        public GameService(IGameRepository gameRepository) : base(gameRepository)
        {
            _gameRepository = gameRepository;
        }
    }
}
