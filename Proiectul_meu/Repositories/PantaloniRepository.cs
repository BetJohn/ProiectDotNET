using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class PantaloniRepository : GenericRepository<Pantaloni>, IPantaloniRepository
    {
        public PantaloniRepository(Contextul context) : base(context) { }
    }
}
