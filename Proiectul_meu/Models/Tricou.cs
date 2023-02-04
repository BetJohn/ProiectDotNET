using Proiectul_meu.Models.Base;

namespace Proiectul_meu.Models
{
    public class Tricou : Baza
    {
        public string? Descriere { get; set; }

        public string? Culoare { get; set; }

        public string? Marime { get; set; }

        public string? Material { get; set; }

        public double? Pret { get; set; }
        public ICollection<TricouLaTrening> TricouLaTreninguri { get; set; }

    }
    
}
//"d23670b7-886f-4301-27d4-08db017a1b45" treninng
//"75b1a5c1-0288-48dc-35e8-08db04928f21"