using Games.Application.Interface;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Application
{
    public class GameAppService : AppServiceBase<Game>, IGameAppService
    {
        private readonly IGameService _gameService;

        public GameAppService(IGameService gameService) : base(gameService)
        {
            _gameService = gameService;
        }
    }
}

