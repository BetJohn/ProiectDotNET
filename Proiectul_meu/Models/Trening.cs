using Proiectul_meu.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiectul_meu.Models
{
    public class Trening : Baza
    {

        [ForeignKey("BluzaId")]
        public Bluza Bluza { get; set; }

        public Guid BluzaId { get; set; }

        public ICollection<TricouLaTrening>? Tricouri { get; set; }

        [ForeignKey("PantaloniId")]
        public Pantaloni Pantaloni { get; set; }

        public Guid PantaloniId { get; set; }
    }
        
}
