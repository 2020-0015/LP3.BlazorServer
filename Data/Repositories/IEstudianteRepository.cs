using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public interface IEstudianteRepository : IRepository<Estudiante>
{
    Task<Estudiante?> GetByMatriculaAsync(string matricula);
}
