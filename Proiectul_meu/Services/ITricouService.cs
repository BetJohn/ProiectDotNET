using Proiectul_meu.Models;

namespace Proiectul_meu.Services
{
    public interface ITricouService
    {
        Task<List<Tricou>> GetAllTricouri();
        Task<Tricou> GetTricouById(int id);
        Task CreateTricou(Tricou tricou);
        Task UpdateTricou(Tricou tricou);
        Task DeleteTricou(int id);
      
    }
}
