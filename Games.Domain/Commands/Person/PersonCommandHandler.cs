using Games.Domain.Interfaces.Repositories;
using MediatR;
using NetDevPack.Messaging;
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Games.Domain.Models;
using Games.Domain.Events.Person;

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

        public async Task<ValidationResult> Handle(RegisterNewPersonCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var person = new PersonModel(Guid.NewGuid(), message.Name, message.Phone, message.Email, message.Created, message.Updated);


            if (await _personRepository.GetByEmail(person.Email) != null)
            {
                AddError("Pessoa já foi cadastrada.");
                return ValidationResult;
            }

            person.AddDomainEvent(new PersonRegisteredEvent(person.Name, person.Phone, person.Email, person.Created));

            _personRepository.Add(person);

            return await Commit(_personRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(UpdatePersonCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var person = new PersonModel(Guid.NewGuid(), message.Name, message.Phone, message.Email, message.Created, message.Updated);


            if (await _personRepository.GetByEmail(person.Email) != null)
            {
                AddError("Pessoa já foi cadastrada.");
                return ValidationResult;
            }

            person.AddDomainEvent(new PersonRegisteredEvent(person.Name, person.Phone, person.Email, person.Created));

            _personRepository.Update(person);

            return await Commit(_personRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(RemovePersonCommand message, CancellationToken cancellationToken)
        {
            if (!message.IsValid()) return message.ValidationResult;

            var person = await _personRepository.GetById(message.Id);

            if (person is null)
            {
                AddError("Pessoa não cadastrada.");
                return ValidationResult;
            }

            person.AddDomainEvent(new PersonRemovedEvent(message.Id));

            _personRepository.Remove(person);

            return await Commit(_personRepository.UnitOfWork);
        }
    }
}
