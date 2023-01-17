using Proiectul_meu.Models.Base;

namespace Proiectul_meu.Models
{
    public class Bluza : Baza
    {
        public string Descriere { get; set; }

        public string Culoare { get; set; }

        public string Marime { get; set; }

        public string Material { get; set; }

        public double Pret { get; set; }

        public bool Hoodie { get; set; }
    }
}
