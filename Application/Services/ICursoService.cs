using LP3.BlazorServer.Shared.DTOs;

namespace LP3.BlazorServer.Application.Services;

public interface ICursoService
{
    Task<ICollection<CursoDto>> GetAll();
    Task<CursoDto?> GetByIdAsync(int id);
    Task<CursoDto?> GetByCodigoAsync(string codigo);
    Task<bool> CreateAsync(CursoDto dto);
    Task<bool> UpdateAsync(int id, CursoDto dto);
    Task<bool> DeleteAsync(int id);
}