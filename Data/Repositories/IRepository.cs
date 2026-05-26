namespace LP3.BlazorServer.Data.Repositories;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAsync();
    Task AddAsync(T entity);
    Task Update(T entity);
    Task Remove(T entity);
}