using AutoMapper;
using Market.Business.Entities.Database;
using Market.WebApi.ViewModel;

namespace Market.WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GameDto, GameViewModel>().ReverseMap();
            CreateMap<UserDto, UserViewModel>().ReverseMap();
        }
    }
}
