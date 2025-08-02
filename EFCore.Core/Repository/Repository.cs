using EFCore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Repository<T, IdT> : IRepository<T, IdT> where T : class
{
    protected readonly QlvtthanDongBacOfficialContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(QlvtthanDongBacOfficialContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    public virtual IQueryable<T> Query => _dbSet.AsQueryable();

    public virtual async Task<T?> GetByIdAsync(IdT id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<List<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public virtual async Task DeleteAsync(IdT id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
