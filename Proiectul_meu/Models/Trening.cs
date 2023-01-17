using Proiectul_meu.Models.Base;

namespace Proiectul_meu.Models
{
    public class Trening : Baza
    {
        public Bluza Bluza { get; set; }

        public ICollection<TricouLaTrening> Tricouri { get; set; }

        public Pantaloni Pantaloni { get; set; }

        public ICollection<Sosete> Sosete { get; set; }
         
    }
        
}
