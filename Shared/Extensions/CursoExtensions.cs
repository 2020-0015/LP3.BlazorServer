using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

namespace LP3.BlazorServer.Shared.Extensions;

public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso curso)
    {
        return new CursoDto
        {
            Id = curso.Id,
            Nombre = curso.Nombre,
            Codigo = curso.Codigo,
            Creditos = curso.Creditos,
            Activo = curso.Activo
        };
    }

    public static Curso ToEntity(this CursoDto dto)
    {
        return new Curso
        {
            Id = dto.Id,
            Nombre = dto.Nombre.Trim(),
            Codigo = dto.Codigo.Trim(),
            Creditos = dto.Creditos,
            Activo = dto.Activo
        };
    }

    public static void UpdateFromDto(this Curso curso, CursoDto dto)
    {
        curso.Nombre = dto.Nombre.Trim();
        curso.Codigo = dto.Codigo.Trim();
        curso.Creditos = dto.Creditos;
        curso.Activo = dto.Activo;
    }
}