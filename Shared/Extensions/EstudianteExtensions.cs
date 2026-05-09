namespace LP3.BlazorServer.Shared.Extensions;

using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

/// <summary>
/// Métodos de extensión para convertir entre la entidad Estudiante y sus DTOs.
/// </summary>
public static class EstudianteExtensions
{
    /// <summary>
    /// Convierte una entidad Estudiante a EstudianteDto.
    /// Este DTO se usa normalmente para mostrar datos en listados o tablas.
    /// </summary>
    public static EstudianteDto ToDto(this Estudiante estudiante)
    {
        return new EstudianteDto
        {
            Id = estudiante.Id,
            Nombre = estudiante.Nombre,
            Apellido = estudiante.Apellido,
            Matricula = estudiante.Matricula,
            Estado = estudiante.Estado.ToString()
        };
    }

    /// <summary>
    /// Convierte una lista de entidades Estudiante a una lista de EstudianteDto.
    /// </summary>
    public static List<EstudianteDto> ToDtoList(this IEnumerable<Estudiante> estudiantes)
    {
        return estudiantes
            .Select(estudiante => estudiante.ToDto())
            .ToList();
    }

    /// <summary>
    /// Convierte un EstudianteFormDto a una entidad Estudiante.
    /// Este método se usa cuando se va a crear un nuevo estudiante.
    /// </summary>
    public static Estudiante ToEntity(this EstudianteFormDto dto)
    {
        return new Estudiante
        {
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Matricula = dto.Matricula,
            Email = dto.Email,
            Estado = dto.Estado
        };
    }

    /// <summary>
    /// Actualiza una entidad Estudiante existente usando los datos de EstudianteFormDto.
    /// Este método se usa cuando se va a editar un estudiante.
    /// </summary>
    public static void UpdateFromDto(this Estudiante estudiante, EstudianteFormDto dto)
    {
        estudiante.Nombre = dto.Nombre;
        estudiante.Apellido = dto.Apellido;
        estudiante.Matricula = dto.Matricula;
        estudiante.Email = dto.Email;
        estudiante.Estado = dto.Estado;
        estudiante.ActualizadoEn = DateTime.UtcNow;
    }
}