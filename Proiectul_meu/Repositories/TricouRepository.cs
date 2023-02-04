using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class TricouRepository : GenericRepository<Tricou>, ITricouRepository
    {
        private const int V = 0x1;

        public TricouRepository(Contextul context) : base(context) { }

        public new async Task<List<Tricou>> GetAll()
        {
            var tricouri = await _context.Tricouri
                .ToListAsync();

            foreach(var tricou in tricouri)
            {
                tricou.TricouLaTreninguri = await _context.TricouriLaTrening
                    .Include(t => t.Tricou)
                    .Include(t => t.Trening)
                    .Where(t => t.Tricou.Id == tricou.Id)
                    .ToListAsync();
            }
            
            return tricouri;
        }
    }
}
