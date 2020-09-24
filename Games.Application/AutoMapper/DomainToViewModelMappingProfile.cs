using AutoMapper;
using Games.Application.ViewModels;
using Games.Domain.Models;

namespace Games.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :  Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<GameModel, GameViewModel>();
            CreateMap<PersonModel, PersonViewModel>();
            CreateMap<GameLendModel, GameLendViewModel>();
        }
    }
}
