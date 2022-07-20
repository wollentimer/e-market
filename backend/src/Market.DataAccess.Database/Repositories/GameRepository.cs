using Market.DataAccess.Database.Context;
using Market.DataAccess.Database.Entities;
using Market.DataAccess.Database.Interfaces;

namespace Market.DataAccess.Database.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
