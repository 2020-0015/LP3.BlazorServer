namespace LP3.BlazorServer.Application.Services
{
    using global::LP3.BlazorServer.Shared.DTOs;

    public interface IEstudianteService
    {
        Task<ICollection<EstudianteDto>> GetAll();
        Task<EstudianteDto?> GetByIdAsync(int id);
        Task<EstudianteDto?> GetByMatriculaAsync(string matricula);
        Task<bool> CreateAsync(EstudianteDto dto);
        Task<bool> UpdateAsync(int id, EstudianteDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
