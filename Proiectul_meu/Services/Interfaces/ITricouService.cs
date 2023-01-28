using Proiectul_meu.Models;
using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface ITricouService
    {
        Task<List<TricouDTO>> GetAllTricouri();
        Task<TricouDTO> GetTricouById(Guid id);
        Task CreateTricou(TricouDTO tricou);
        Task UpdateTricou(TricouDTO tricou);
        Task DeleteTricou(Guid id);
    }
}
