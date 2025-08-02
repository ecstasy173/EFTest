using System.Collections.Generic;
using System.Threading.Tasks;

public interface IRepository<T, IdT> where T : class
{
    Task<T?> GetByIdAsync(IdT id);
    Task<List<T>> GetAllAsync();
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(IdT id);
}
