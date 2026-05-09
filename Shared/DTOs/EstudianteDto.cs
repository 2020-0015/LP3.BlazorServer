using LP3.BlazorServer.Domain.Enums;

namespace LP3.BlazorServer.Shared.DTOs
{
    /// <summary>DTO para mostrar estudiantes en listados.</summary>
    public class EstudianteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }

    /// <summary>DTO para crear o editar un estudiante.</summary>
    public class EstudianteFormDto
    {
        public int? Id { get; set; }  // null = crear nuevo
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public EstadoEstudiante Estado { get; set; } = EstadoEstudiante.Activo;
    }
}
