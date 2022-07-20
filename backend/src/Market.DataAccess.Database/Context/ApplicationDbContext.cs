using Market.DataAccess.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Database.Context
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game>? Games { get; set; }
    }
}