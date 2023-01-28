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
            await _context.SaveChangesAsync();
        }
    }
}
