using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface ITricouLaTreningService
    {
        Task<List<TricouLaTreningDTO>> GetAllTricouLaTrening();
        Task<TricouLaTreningDTO> GetTricouLaTreningById(Guid id);
        Task CreateTricouLaTrening(TricouLaTreningDTO tricouLaTrening);
        Task UpdateTricouLaTrening(TricouLaTreningDTO tricouLaTrening);
        Task DeleteTricouLaTrening(Guid id);
    }
}
