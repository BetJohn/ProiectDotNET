using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface IBluzaService
    {
        Task<List<BluzaDTO>> GetAllBluze();
        Task<BluzaDTO> GetBluzaById(Guid id);
        Task CreateBluza(BluzaDTO bluza);
        Task UpdateBluza(BluzaDTO bluza);
        Task DeleteBluza(Guid id);
    }
}
