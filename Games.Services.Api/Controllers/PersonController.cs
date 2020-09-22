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
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonAppService _personAppService;
        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        [AllowAnonymous]
        [HttpGet("person")]
        public async Task<IEnumerable<PersonViewModel>> Get()
        {
            return await _personAppService.GetAll();
        }
    }
}
