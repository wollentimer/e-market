using AutoMapper;
using Market.Business.Entities.Database;
using Market.WebApi.ViewModel;

namespace Market.WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GameDto, GameViewModel>()
                .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();
            CreateMap<UserDto, UserViewModel>()
                .ForMember(o => o.Id, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();
        }
    }
}
