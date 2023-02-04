using Microsoft.EntityFrameworkCore;
using Proiectul_meu.Data;
using Proiectul_meu.Models;
using Proiectul_meu.Repositories.Interfaces;

namespace Proiectul_meu.Repositories
{
    public class SoseteRepository : GenericRepository<Sosete>, ISoseteRepository
    {
        public SoseteRepository(Contextul context) : base(context) { }

        public new async Task CreateAsync(Sosete sosete)
        {
            _context.Sosete.Add(sosete);
            if (_context.Treninguri.Any(t => t.Id == sosete.Trening.Id))
            {
                _context.Entry(sosete.Trening).State = EntityState.Unchanged;
            }

            if (_context.Bluze.Any(t => t.Id == sosete.Trening.Bluza.Id))
            {
                _context.Entry(sosete.Trening.Bluza).State = EntityState.Unchanged;
            }

            if (_context.Pantaloni.Any(t => t.Id == sosete.Trening.Pantaloni.Id))
            {
                _context.Entry(sosete.Trening.Pantaloni).State = EntityState.Unchanged;
            }

            await _context.SaveChangesAsync();
        }

        public new async Task<List<Sosete>> GetAll()
        {
            return await _context.Sosete
                .Include(s => s.Trening)
                .ToListAsync();
        }
    }
}
