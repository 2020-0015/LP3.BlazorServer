using LP3.BlazorServer.Domain.Enums;

namespace LP3.BlazorServer.Domain.Entities
{
    public class Estudiante
    {
        // ── Identificador único ───────────────────────────────
        public int Id { get; set; }

        // ── Datos del estudiante ──────────────────────────────
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }

        // ── Estado usando un Enum (lo veremos más adelante) ───
        public EstadoEstudiante Estado { get; set; } = EstadoEstudiante.Activo;

        // ── Auditoría ─────────────────────────────────────────
        public DateTime CreadoEn { get; set; } = DateTime.UtcNow;
        public DateTime? ActualizadoEn { get; set; }

        // ── Navegación (relaciones) ───────────────────────────
        public ICollection<Matriculacion> Matriculaciones { get; set; } = new List<Matriculacion>();
    }
}

