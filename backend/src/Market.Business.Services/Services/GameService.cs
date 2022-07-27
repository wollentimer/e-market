using AutoMapper;
using Market.Business.Entities.Database;
using Market.Business.Services.Interfaces;
using Market.DataAccess.Database.Interfaces;

namespace Market.Business.Services.Services
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;
        private readonly IGameRepository _gameRepository;

        public GameService(IMapper mapper ,IGameRepository gameRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository;
        }

        public Task<GameDto> CreateAsync(GameDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GameDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GameDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<GameDto>>(await _gameRepository.GetAllAsync());
        }

        public Task<GameDto> UpdateAsync(GameDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
