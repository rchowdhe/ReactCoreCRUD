using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactCoreCRUD.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity, int id);
        Task DeleteAsync(int id);
    }
}
