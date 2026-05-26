using Microsoft.EntityFrameworkCore;
using LP3.BlazorServer.Domain.Entities;

namespace LP3.BlazorServer.Data.Repositories;

public class EstudianteRepository(ApplicationDbContext context) : Repository<Estudiante>(context), IEstudianteRepository
{
    public async Task<Estudiante?> GetByMatriculaAsync(string matricula)
    {
        return await context.Estudiantes
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.Matricula == matricula);
    }
}