using Proiectul_meu.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiectul_meu.Models
{

    public class TricouLaTrening : Baza   
    {
        public Guid TreningID { get; set; }
        [ForeignKey("TreningID")]
        public Trening Trening { get; set; }
        public Guid TricouID { get; set; }
        [ForeignKey("TricouID")]
        public Tricou Tricou { get; set; }
    }
}
