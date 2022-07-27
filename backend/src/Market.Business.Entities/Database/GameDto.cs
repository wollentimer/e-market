using Market.Business.Entities.Base;

namespace Market.Business.Entities.Database
{
    public class GameDto : BaseDto
    {
        public UserDto User { get; set; }
    }
}
