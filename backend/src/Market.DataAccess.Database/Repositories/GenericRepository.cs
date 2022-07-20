using Market.DataAccess.Database.Context;
using Market.DataAccess.Database.Entities;
using Market.DataAccess.Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Database.Repositories
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity>
		where TEntity : BaseEntity
	{
		protected ApplicationDbContext Context { get; }
		protected DbSet<TEntity> EntityDbSet { get; }
        public virtual IQueryable<TEntity> Query => EntityDbSet.AsQueryable();

		public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
            EntityDbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
			return await EntityDbSet.AsNoTracking().ToListAsync();
		}

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
			return (await EntityDbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id))!;
		}

		public virtual async Task InsertAsync(TEntity entity)
		{
			await EntityDbSet.AddAsync(entity);
			await Context.SaveChangesAsync();

			DetachAsync(entity);
		}

		public virtual async Task<TEntity> UpdateAsync(TEntity entity)
		{
			EntityDbSet.Update(entity);
			
			await Context.SaveChangesAsync();
			
			DetachAsync(entity);
			
			return entity;
		}

		public virtual async Task DeleteAsync(int id)
		{
			TEntity entity = await Query.FirstAsync(x => x.Id == id);
            if (entity == null) throw new ArgumentNullException(nameof(entity));

			await DeleteAsync(entity);
		}

		public virtual async Task DeleteAsync(TEntity entity)
		{
			EntityDbSet.Remove(entity);
			await Context.SaveChangesAsync();
		}

		protected void DetachAsync<T>(T entity)
			where T : class
		{
			Context.Entry(entity).State = EntityState.Detached;
		}
	}
}
