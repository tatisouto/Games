using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Domain.Interfaces.Services;

namespace Games.Domain.Services
{
    public class PersonService : ServiceBase<Person>, IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {
            _personRepository = personRepository;
        }
    }
}

