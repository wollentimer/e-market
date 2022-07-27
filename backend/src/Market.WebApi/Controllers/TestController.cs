using AutoMapper;
using Market.Business.Services.Interfaces;
using Market.WebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Market.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public TestController(IMapper mapper, IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<GameViewModel>> Get()
        {
            var result = _mapper.Map<IEnumerable<GameViewModel>>(await _gameService.GetAllAsync());
            return result;
        }
    }
}
