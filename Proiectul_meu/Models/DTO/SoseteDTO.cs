namespace Proiectul_meu.Models.DTO
{
    public class SoseteDTO
    {
        public Guid Id { get; set; }
        public string Descriere { get; set; }
        public string Culoare { get; set; }
        public string Marime { get; set; }
        public string Material { get; set; }
        public double Pret { get; set; }
        public bool Scurte { get; set; }
        public bool Diferite { get; set; }
        public TreningDTO? Trening { get; set; }
    }
}
