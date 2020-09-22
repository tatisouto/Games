using AutoMapper;
using Games.Application.ViewModels;
using Games.Domain.Commands;
using Games.Domain.Commands.Game;
using Games.Domain.Commands.GameLend;
using Games.Domain.Commands.Person;

namespace Games.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PersonViewModel, RegisterNewPersonCommand>()
            .ConstructUsing(c => new RegisterNewPersonCommand(c.Name, c.Phone, c.Email, c.Created));
            CreateMap<PersonViewModel, UpdatePersonCommand>()
                .ConstructUsing(c => new UpdatePersonCommand(c.Id, c.Name, c.Phone, c.Email, c.Created, c.Updated));


            CreateMap<GameViewModel, RegisterNewGameCommand>()
              .ConstructUsing(c => new RegisterNewGameCommand(c.Description, c.Active, c.Created, c.Updated));
            CreateMap<GameViewModel, UpdateGameCommand>()
                .ConstructUsing(c => new UpdateGameCommand(c.Id, c.Description, c.Active, c.Created, c.Updated));

            CreateMap<GameLendViewModel, RegisterNewGameLendCommand>()
                .ConstructUsing(c => new RegisterNewGameLendCommand(c.IdPerson, c.IdGame, c.LendOn, c.ReturnedOn, c.Created, c.Updated));
            CreateMap<GameLendViewModel, UpdateGameLendCommand>()
                .ConstructUsing(c => new UpdateGameLendCommand(c.Id, c.IdGame, c.IdPerson, c.LendOn, c.ReturnedOn, c.Created, c.Updated));
        }
    }
}



