using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface ITreningService
    {
        Task<List<TreningDTO>> GetAllTreninguri();
        Task<TreningDTO> GetTreningById(Guid id);
        Task CreateTrening(TreningDTO trening);
        Task UpdateTrening(TreningDTO trening);
        Task DeleteTrening(Guid id);
    }
}
