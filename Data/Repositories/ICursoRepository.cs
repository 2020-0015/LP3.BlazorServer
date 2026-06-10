using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public interface ICursoRepository : IRepository<Curso>
{
    Task<Curso?> GetByCodigoAsync(string codigo);
}