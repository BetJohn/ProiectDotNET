using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface ISoseteService
    {
        Task<List<SoseteDTO>> GetAllSosete();
        Task<SoseteDTO> GetSoseteById(Guid id);
        Task CreateSosete(SoseteDTO sosete);
        Task UpdateSosete(SoseteDTO sosete);
        Task DeleteSosete(Guid id);
    }
}
