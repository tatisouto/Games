using AutoMapper;
using FluentValidation.Results;
using Games.Application.Interfaces;
using Games.Application.ViewModels;
using Games.Domain.Entities;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Repository.EventSourcing;
using NetDevPack.Mediator;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Games.Application.Services
{
    public class GameLendAppService : IGameLendAppService
    {
        private readonly IMapper _mapper;
        private readonly IGameLendRepository _customerRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler _mediator;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GameLendViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GameLendViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Register(GameLendViewModel objViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Update(GameLendViewModel objViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
