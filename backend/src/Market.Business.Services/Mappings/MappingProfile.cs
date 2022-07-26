using AutoMapper;
using Market.Business.Entities.Database;
using Market.DataAccess.Database.Entities;

namespace Market.Business.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GameDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
