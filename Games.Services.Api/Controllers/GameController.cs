using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
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
    public class GameController : ApiController
    {
        private readonly IGameAppService _gameAppService;

        public GameController(IGameAppService gameAppService)
        {
            _gameAppService = gameAppService;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<GameViewModel>> Get()
        {
            return await _gameAppService.GetAll();
        }


        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<GameViewModel> Get(Guid id)
        {
            return await _gameAppService.GetById(id);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] GameViewModel gameViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _gameAppService.Register(gameViewModel));
        }
    
        [HttpPut("")]
        public async Task<IActionResult> Put([FromBody] GameViewModel gameViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _gameAppService.Update(gameViewModel));
        }

       
        [HttpDelete("")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return CustomResponse(await _gameAppService.Remove(id));
        }
    }
}


