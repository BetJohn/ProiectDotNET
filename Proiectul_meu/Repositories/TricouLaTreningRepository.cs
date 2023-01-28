using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class TricouLaTreningRepository : GenericRepository<TricouLaTrening>, ITricouLaTreningRepository
    {
        public TricouLaTreningRepository(Contextul context) : base(context) { }

        public async Task CreateAsync(TricouLaTrening tricouLaTrening)
        {
            _context.TricouriLaTrening.Add(tricouLaTrening);
            if (_context.Treninguri.Any(t => t.Id == tricouLaTrening.Trening.Id))
            {
                _context.Entry(tricouLaTrening.Trening).State = EntityState.Unchanged;
            }

            if (_context.Tricouri.Any(t => t.Id == tricouLaTrening.Tricou.Id))
            {
                _context.Entry(tricouLaTrening.Tricou).State = EntityState.Unchanged;
            }
            
            await _context.SaveChangesAsync();
        }
    }
}
