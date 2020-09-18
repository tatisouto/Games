using Games.Application.Interface;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Application
{
    public class PersonAppService : AppServiceBase<Person>, IPersonAppService
    {
        private readonly IPersonService _personService;

        public PersonAppService(IPersonService personService) : base(personService)
        {
            _personService = personService;
        }
    }
}
