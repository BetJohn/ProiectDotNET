using Proiectul_meu.Models.Base;

namespace Proiectul_meu.Models
{

    public class TricouLaTrening : Baza   
    {
        public Guid TreningID { get; set; }
        public Trening Trening { get; set; }
        public Guid TricouID { get; set; }
        public Tricou Tricou { get; set; }

        
    }
}
