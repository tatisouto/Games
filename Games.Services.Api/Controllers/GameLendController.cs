using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Games.Services.Api.Controllers
{
    [Route("v1/gamesLend")]
    [ApiController]
    public class GameLendController : ApiController
    {


        private readonly IGameLendAppService _gameLendAppService;

        public GameLendController(IGameLendAppService gameLendAppService)
        {
            _gameLendAppService = gameLendAppService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<GameLendViewModel>> Get()
        {
            return await _gameLendAppService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<GameLendViewModel> Get(Guid id)
        {
            return await _gameLendAppService.GetById(id);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] GameLendViewModel gameLendViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _gameLendAppService.Register(gameLendViewModel));
        }

        [HttpPut("")]
        public async Task<IActionResult> Put([FromBody] GameLendViewModel gameLendViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _gameLendAppService.Update(gameLendViewModel));
        }


        [HttpDelete("")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return CustomResponse(await _gameLendAppService.Remove(id));
        }

    }
}
