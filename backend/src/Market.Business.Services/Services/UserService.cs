using Market.Business.Entities.Database;
using Market.Business.Services.Interfaces;

namespace Market.Business.Services.Services
{
    public class UserService : IUserService
    {
        public Task<UserDto> CreateAsync(UserDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> UpdateAsync(UserDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
