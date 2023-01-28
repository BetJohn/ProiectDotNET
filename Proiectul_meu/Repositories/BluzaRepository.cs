using Proiectul_meu.Models;
using Proiectul_meu.Data;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class BluzaRepository : GenericRepository<Bluza>, IBluzaRepository
    {
        public BluzaRepository(Contextul context) : base(context) { }
    }
}
