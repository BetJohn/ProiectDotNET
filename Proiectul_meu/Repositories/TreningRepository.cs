using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class TreningRepository : GenericRepository<Trening>, ITreningRepository
    {
        public TreningRepository(Contextul context) : base(context) { }
    }
}
