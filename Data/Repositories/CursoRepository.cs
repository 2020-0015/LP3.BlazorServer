using LP3.BlazorServer.Data;
using LP3.BlazorServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LP3.BlazorServer.Data.Repositories;

public class CursoRepository(ApplicationDbContext context) : Repository<Curso>(context), ICursoRepository
{
    public async Task<Curso?> GetByCodigoAsync(string codigo)
    {
        if (string.IsNullOrWhiteSpace(codigo))
        {
            return null;
        }

        string codigoNormalizado = codigo.Trim();

        return await context.Set<Curso>()
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Codigo == codigoNormalizado);
    }
}