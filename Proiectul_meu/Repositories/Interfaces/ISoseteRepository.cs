using Proiectul_meu.Models;

namespace Proiectul_meu.Repositories.Interfaces
{
    public interface ISoseteRepository : IGenericRepository<Sosete>
    {
        new Task CreateAsync(Sosete sosete);
    }
}
