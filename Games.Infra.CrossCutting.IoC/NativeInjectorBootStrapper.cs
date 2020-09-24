using Games.Domain.Core.Events;
using Game.Infra.CrossCutting.Bus;
using Games.Infra.Data.Contexts;
using Games.Infra.Data.Repository.EventSourcing;
using Games.Infra.Data.EventSourcing;
using Games.Application.Interfaces;
using Games.Application.Services;
using Games.Domain.Interfaces.Repositories;
using Games.Infra.Data.Repository;
using Games.Domain.Events.Person;
using FluentValidation.Results;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Mediator;
using Games.Domain.Commands;
using Games.Domain.Commands.Game;
using Games.Domain.Commands.Person;
using Games.Domain.Commands.GameLend;

namespace Games.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Application
            services.AddScoped<IPersonAppService, PersonAppService>();
            services.AddScoped<IGameAppService, GameAppService>();
            services.AddScoped<IGameLendAppService, GameLendAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<PersonRegisteredEvent>, PersonEventHandler>();
            services.AddScoped<INotificationHandler<PersonUpdatedEvent>, PersonEventHandler>();
            services.AddScoped<INotificationHandler<PersonRemovedEvent>, PersonEventHandler>();

            services.AddScoped<INotificationHandler<GameRegisteredEvent>, GameEventHandler>();
            services.AddScoped<INotificationHandler<GameUpdatedEvent>, GameEventHandler>();
            services.AddScoped<INotificationHandler<GameRemovedEvent>, GameEventHandler>();

            services.AddScoped<INotificationHandler<GameLendRegisteredEvent>, GameLendEventHandler>();
            services.AddScoped<INotificationHandler<GameLendUpdatedEvent>, GameLendEventHandler>();
            services.AddScoped<INotificationHandler<GameLendRemovedEvent>, GameLendEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewPersonCommand, ValidationResult>, PersonCommandHandler>();
            services.AddScoped<IRequestHandler<UpdatePersonCommand, ValidationResult>, PersonCommandHandler>();
            services.AddScoped<IRequestHandler<RemovePersonCommand, ValidationResult>, PersonCommandHandler>();


            services.AddScoped<IRequestHandler<RegisterNewGameCommand, ValidationResult>, GameCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateGameCommand, ValidationResult>, GameCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveGameCommand, ValidationResult>, GameCommandHandler>();

            services.AddScoped<IRequestHandler<RegisterNewGameLendCommand, ValidationResult>, GameLendCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateGameLendCommand, ValidationResult>, GameLendCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveGameLendCommand, ValidationResult>, GameLendCommandHandler>();

            // Infra - Data

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IGameLendRepository, GameLendRepository>();
            services.AddScoped<GamesContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSQLContext>();
        }
    }
}
