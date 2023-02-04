using Proiectul_meu.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiectul_meu.Models
{

    public class TricouLaTrening : Baza   
    {
        public Guid TreningId { get; set; }
        public Guid TricouId { get; set; }
        public Trening Trening { get; set; }
        public Tricou Tricou { get; set; }
    }
}
