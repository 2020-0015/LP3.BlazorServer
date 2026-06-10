using System.ComponentModel.DataAnnotations;

namespace LP3.BlazorServer.Shared.DTOs;

public class CursoDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del curso es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El código del curso es obligatorio")]
    [StringLength(20, ErrorMessage = "El código no puede exceder los 20 caracteres")]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La cantidad de créditos es obligatoria")]
    [Range(1, 10, ErrorMessage = "Los créditos deben estar entre 1 y 10")]
    public int Creditos { get; set; } = 1;

    public bool Activo { get; set; } = true;
}