using AutoMapper;
using Games.Application.ViewModels;
using Games.Domain.Entities;

namespace Games.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :  Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Game, GameViewModel>();
            CreateMap<Person, PersonViewModel>();
            CreateMap<GameLend, GameLendViewModel>();
        }
    }
}
