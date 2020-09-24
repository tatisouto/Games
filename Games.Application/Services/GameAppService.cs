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
using Games.Domain.Commands.Game;

namespace Games.Application.Services
{
    public class GameAppService : IGameAppService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly IGameRepository _gameRepository;
        private readonly IEventStoreRepository _eventStoreRepository;

        public GameAppService(IMapper mapper,
                                  IGameRepository gameRepository,
                                  IMediatorHandler mediator,
                                  IEventStoreRepository eventStoreRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository;
            _mediator = mediator;
            _eventStoreRepository = eventStoreRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<GameViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<GameViewModel>>(await _gameRepository.GetAll());
        }

        public async Task<IList<PersonHistoryData>> GetAllHistory(Guid id)
        {
            return PersonHistory.ToJavaScriptCustomerHistory(await _eventStoreRepository.All(id));

        }

        public async Task<GameViewModel> GetById(Guid id)
        {
            return _mapper.Map<GameViewModel>(await _gameRepository.GetById(id));
        }

        public async Task<ValidationResult> Register(GameViewModel objViewModel)
        {
            var registerCommand = _mapper.Map<RegisterNewGameCommand>(objViewModel);
            return await _mediator.SendCommand(registerCommand);
        }

        public async Task<ValidationResult> Remove(Guid id)
        {
            var removeCommand = new RemoveGameCommand(id);
            return await _mediator.SendCommand(removeCommand);

        }

        public async Task<ValidationResult> Update(GameViewModel objViewModel)
        {
            var updateCommand = _mapper.Map<UpdateGameCommand>(objViewModel);
            return await _mediator.SendCommand(updateCommand);
        }
    }
}


