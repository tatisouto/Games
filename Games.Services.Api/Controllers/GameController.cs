using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Games.Application.Interfaces;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Games.Services.Api.Controllers
{

    [Route("v1/games")]
    [ApiController]
    // [Authorize]
    public class GameController : ControllerBase
    {
        private readonly IGameAppService _gameApp;

        public GameController(IGameAppService gameApp)
        {
            _gameApp = gameApp;
        }

        //[Route("")]
        //[HttpGet]
        //public IEnumerable<Game> GetAll([FromServices] IGameRepository repository)
        //{
        //    //var user = User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;
        //    return repository.GetAll();
        //}
    }
}


