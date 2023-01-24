using Proiectul_meu.Data;
using Proiectul_meu.Models;

namespace Proiectul_meu.Repositories
{
    public class TricouRepository : GenericRepository<Tricou>, ITricouRepository
    {
        public TricouRepository(Contextul context) : base(context) { }
        
        
    }
}
