using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Games.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Games.Services.Api.Controllers
{

    [Route("v1/games")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameAppService _gameApp;

        public GameController(IGameAppService gameApp)
        {
            _gameApp = gameApp;
        }
    }
}
