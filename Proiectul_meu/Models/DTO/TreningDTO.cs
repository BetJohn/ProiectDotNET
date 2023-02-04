using System.Runtime.InteropServices;

namespace Proiectul_meu.Models.DTO
{
    public class TreningDTO
    {
        public Guid Id { get; set; }
        public BluzaDTO? Bluza { get; set; }
        public Guid? BluzaId { get; set; }
        public List<TricouLaTreningDTO>? Tricouri { get; set; }
        public PantaloniDTO? Pantaloni { get; set; }
    }
}
