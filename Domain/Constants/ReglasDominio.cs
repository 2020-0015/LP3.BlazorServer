namespace LP3.BlazorServer.Domain.Constants
{
    /// <summary>
    /// Reglas y límites del dominio académico.
    /// </summary>
    public static class ReglasDominio
    {
        // ── Estudiante ────────────────────────────────────────
        public const int NombreMaxLongitud = 80;
        public const int MatriculaMaxLongitud = 10;
        public const int MaxCursosPorPeriodo = 6;

        // ── Calificaciones ────────────────────────────────────
        public const decimal CalificacionMinima = 0m;
        public const decimal CalificacionMaxima = 100m;
        public const decimal CalificacionAprobado = 60m;

        // ── Mensajes de error ─────────────────────────────────
        public const string ErrorNombreRequerido = "El nombre es obligatorio.";
        public const string ErrorEmailInvalido = "El email no tiene formato válido.";
        public const string ErrorCursosExcedidos = "No puede inscribirse en más de 6 cursos por período.";
    }
}
