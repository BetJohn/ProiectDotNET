using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class TricouRepository : GenericRepository<Tricou>, ITricouRepository
    {
        private const int V = 0x1;

        public TricouRepository(Contextul context) : base(context) { }
    }
}
