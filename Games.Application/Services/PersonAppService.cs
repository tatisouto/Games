using AutoMapper;
using FluentValidation.Results;
using Games.Application.EventSourcedNormalizers;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using AutoMapper;
using FluentValidation.Results;
using Games.Application.EventSourcedNormalizers;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Mediator;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Repository.EventSourcing;
using Games.Domain.Commands;
using Games.Domain.Commands.Person;

namespace Games.Application.Services
{
    public class PersonAppService : IPersonAppService
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _mediator;

        public PersonAppService(IMapper mapper,
                                IPersonRepository personRepository,
                                IMediatorHandler mediator,
                                IEventStoreRepository eventStoreRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _mediator = mediator;
            _eventStoreRepository = eventStoreRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<PersonViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<PersonViewModel>>(await _personRepository.GetAll());

        }

        public async Task<PersonViewModel> GetById(Guid id)
        {
            return _mapper.Map<PersonViewModel>(await _personRepository.GetById(id));
        }

        public async Task<ValidationResult> Register(PersonViewModel objViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewPersonCommand>(objViewModel);
            return await _mediator.SendCommand(registerCommand);
        }

        public async Task<ValidationResult> Remove(Guid id)
        {
            var removeCommand = new RemovePersonCommand(id);
            return await _mediator.SendCommand(removeCommand);
        }

        public async Task<ValidationResult> Update(PersonViewModel objViewModel)
        {
            var updateCommand = _mapper.Map<UpdateGameCommand>(objViewModel);
            return await _mediator.SendCommand(updateCommand);
        }
    }
}
