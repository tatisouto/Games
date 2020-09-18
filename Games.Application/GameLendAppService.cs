using Games.Application.Interface;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Application
{
    public class GameLendAppService : AppServiceBase<GameLend>, IGameLendAppService
    {
        private readonly IGameLendService _gameLendService;
        public GameLendAppService(IGameLendService gameLendService) : base(gameLendService)
        {
            _gameLendService = gameLendService;
        }
    }
}
