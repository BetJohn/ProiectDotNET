using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class TreningRepository : GenericRepository<Trening>, ITreningRepository
    {
        public TreningRepository(Contextul context) : base(context) { }

        public new async Task CreateAsync(Trening trening)
        {
            _context.Treninguri.Add(trening);
            if (_context.Pantaloni.Any(p => p.Id == trening.Pantaloni!.Id))
            {
                _context.Entry(trening.Pantaloni).State = EntityState.Unchanged;
            }

            if (_context.Bluze.Any(b => b.Id == trening.Bluza!.Id))
            {
                _context.Entry(trening.Bluza).State = EntityState.Unchanged;
            }
            
            await _context.SaveChangesAsync();
        }

        public new async Task<List<Trening>> GetAll()
        {
            var treninguri = await _context.Treninguri
                .Include(t => t.Pantaloni)
                .Include(t => t.Bluza)
                .ToListAsync();

            foreach (var trening in treninguri)
            {
                trening.Tricouri = await _context.TricouriLaTrening
                    .Include(t => t.Trening)
                    .Include(t => t.Tricou)
                    .Where(t => t.Trening.Id == trening.Id)
                    .ToListAsync();
            }

            return treninguri;
        }
    }
}
