namespace LP3.BlazorServer.Domain.Entities
{
    public class Matriculacion
    {
        public int Id { get; set; }

        // ── Claves foráneas (FK) ──────────────────────────────
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }

        // ── Datos propios de la matrícula ─────────────────────
        public DateTime FechaInscripcion { get; set; } = DateTime.UtcNow;
        public decimal? CalificacionFinal { get; set; }   // null = sin calificar

        // ── Propiedades de navegación ─────────────────────────
        // Permiten acceder al objeto completo: matricula.Estudiante.Nombre
        public Estudiante Estudiante { get; set; } = null!;
        public Curso Curso { get; set; } = null!;
    }
}
