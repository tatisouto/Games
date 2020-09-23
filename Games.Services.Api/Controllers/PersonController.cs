using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetDevPack.Identity.Authorization;
using Games.Application.EventSourcedNormalizers;


namespace Games.Services.Api.Controllers
{
    [Route("v1/persons")]
    [ApiController]
    public class PersonController : ApiController
    {
        private readonly IPersonAppService _personAppService;
        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<PersonViewModel>> Get()
        {
            return await _personAppService.GetAll();
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<PersonViewModel> Get(Guid id)
        {
            return await _personAppService.GetById(id);
        }

        [AllowAnonymous]       
        public async Task<IActionResult> Post([FromBody] PersonViewModel personViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _personAppService.Register(personViewModel));
        }

        [HttpPut("")]
        public async Task<IActionResult> Put([FromBody] PersonViewModel gameViewModel)
        {
            return !ModelState.IsValid ? CustomResponse(ModelState) : CustomResponse(await _personAppService.Update(gameViewModel));
        }


        [HttpDelete("")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return CustomResponse(await _personAppService.Remove(id));
        }
    }
}
