using Proiectul_meu.Models.DTO;

namespace Proiectul_meu.Services.Interfaces
{
    public interface IPantaloniService
    {
        Task<List<PantaloniDTO>> GetAllPantaloni();
        Task<PantaloniDTO> GetPantaloniById(Guid id);
        Task CreatePantaloni(PantaloniDTO pantaloni);
        Task UpdatePantaloni(PantaloniDTO pantaloni);
        Task DeletePantaloni(Guid id);
    }
}
