using FluentValidation.Results;
using AutoMapper;
using NetDevPack.Mediator;
using Games.Application.Interfaces;
using Games.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Domain;

namespace Games.Application.Services
{
    //public class AppServiceBase : IAppServiceBase
    //{
    //    private readonly IServiceBase _serviceBase;
    //    private readonly IMapper _mapper;
    //    private readonly IMediatorHandler _mediator;

    //    public AppServiceBase()
    //    {

    //    }

    //    public void Dispose()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IEnumerable<Entity>> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<TEntity> GetById(Guid id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<ValidationResult> Register(TEntity obj)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<ValidationResult> Remove(Guid id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<ValidationResult> Update(TEntity obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

