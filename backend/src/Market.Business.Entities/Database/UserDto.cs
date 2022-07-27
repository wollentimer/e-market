using Market.Business.Entities.Base;

namespace Market.Business.Entities.Database
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<GameDto> Games { get; set; }
    }
}
