namespace Proiectul_meu.Models
{
    public class TricouDTO
    {
        public string Descriere { get; set; }

        public string Culoare { get; set; }

        public string Marime { get; set; }

        public string Material { get; set; }

        public double Pret { get; set; }
        public ICollection<TricouLaTrening> TricouLaTreninguri { get; set; }
    }
}
