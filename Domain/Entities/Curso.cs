namespace LP3.BlazorServer.Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Codigo { get; set; } = string.Empty;   // Ej: "IRI-005"
        public int Creditos { get; set; }
        public bool Activo { get; set; } = true;

        // 1:N → un Curso tiene muchas Matriculaciones
        public ICollection<Matriculacion> Matriculaciones { get; set; } = new List<Matriculacion>();
    }
}
