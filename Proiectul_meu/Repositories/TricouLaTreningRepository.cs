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

            if (_context.Bluze.Any(t => t.Id == tricouLaTrening.Trening.Bluza.Id))
            {
                _context.Entry(tricouLaTrening.Trening.Bluza).State = EntityState.Unchanged;
            }

            if (_context.Pantaloni.Any(t => t.Id == tricouLaTrening.Trening.Pantaloni.Id))
            {
                _context.Entry(tricouLaTrening.Trening.Pantaloni).State = EntityState.Unchanged;
            }

            if (_context.Tricouri.Any(t => t.Id == tricouLaTrening.Tricou.Id))
            {
                _context.Entry(tricouLaTrening.Tricou).State = EntityState.Unchanged;
            }
            
            await _context.SaveChangesAsync();
        }

        public async Task<List<TricouLaTrening>> GetAll()
        {

            return await _context.TricouriLaTrening.Include(t => t.Tricou).Include(t => t.Trening).ToListAsync();
        }
    }
}
