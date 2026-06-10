using LP3.BlazorServer.Data.Repositories;
using LP3.BlazorServer.Shared.DTOs;
using LP3.BlazorServer.Shared.Extensions;

namespace LP3.BlazorServer.Application.Services;

public class CursoService(ICursoRepository cursoRepository) : ICursoService
{
    public async Task<ICollection<CursoDto>> GetAll()
    {
        var cursos = await cursoRepository.ListAsync();

        return cursos
            .Select(c => c.ToDto())
            .OrderBy(c => c.Nombre)
            .ToList();
    }

    public async Task<CursoDto?> GetByIdAsync(int id)
    {
        var curso = await cursoRepository.GetByIdAsync(id);

        return curso?.ToDto();
    }

    public async Task<CursoDto?> GetByCodigoAsync(string codigo)
    {
        var curso = await cursoRepository.GetByCodigoAsync(codigo);

        return curso?.ToDto();
    }

    public async Task<bool> CreateAsync(CursoDto dto)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(dto.Nombre) ||
                string.IsNullOrWhiteSpace(dto.Codigo) ||
                dto.Creditos <= 0)
            {
                return false;
            }

            var cursoExistente = await cursoRepository.GetByCodigoAsync(dto.Codigo);

            if (cursoExistente != null)
            {
                return false;
            }

            var curso = dto.ToEntity();

            await cursoRepository.AddAsync(curso);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(int id, CursoDto dto)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);

            if (curso == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(dto.Nombre) ||
                string.IsNullOrWhiteSpace(dto.Codigo) ||
                dto.Creditos <= 0)
            {
                return false;
            }

            var cursoConMismoCodigo = await cursoRepository.GetByCodigoAsync(dto.Codigo);

            if (cursoConMismoCodigo != null && cursoConMismoCodigo.Id != id)
            {
                return false;
            }

            curso.UpdateFromDto(dto);

            await cursoRepository.Update(curso);

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var curso = await cursoRepository.GetByIdAsync(id);

            if (curso == null)
            {
                return false;
            }

            await cursoRepository.Remove(curso);

            return true;
        }
        catch
        {
            return false;
        }
    }
}