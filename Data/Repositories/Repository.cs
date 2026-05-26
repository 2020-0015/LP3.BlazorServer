using Microsoft.EntityFrameworkCore;

namespace LP3.BlazorServer.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _set;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _set = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(int id) => await _set.FindAsync(id);

    public async Task<IReadOnlyList<T>> ListAsync() => await _set.AsNoTracking().ToListAsync();

    public async Task AddAsync(T entity)
    {
        await _set.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _set.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(T entity)
    {
        _set.Remove(entity);
        await _context.SaveChangesAsync();
    }
}