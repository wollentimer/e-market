using Market.Business.Entities.Base;

namespace Market.Business.Services.Interfaces
{
    public interface IBaseService<T> where T : BaseDto
    {
        public Task<T> CreateAsync(T entity);

        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);

        public Task<T> UpdateAsync(T entity);

        public Task DeleteAsync(int id);
    }
}
