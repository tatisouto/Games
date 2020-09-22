using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Games.Domain.Commands.Person
{
    public class PersonCommandHandler : CommandHandler, 
        IRequestHandler<RegisterNewPersonCommand, ValidationResult>,
        IRequestHandler<UpdatePersonCommand, ValidationResult>,
        IRequestHandler<RemovePersonCommand, ValidationResult>
    {
        private readonly IPersonRepository _personRepository;
 
        public PersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Task<ValidationResult> Handle(RegisterNewPersonCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
