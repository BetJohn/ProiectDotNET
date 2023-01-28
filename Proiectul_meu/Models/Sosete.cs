﻿using Proiectul_meu.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiectul_meu.Models
{

    public class Sosete : Baza
    {
        public string Descriere { get; set; }

        public string Culoare { get; set; }

        public string Marime { get; set; }

        public string Material { get; set; }

        public double Pret { get; set; }

        public bool Scurte { get; set; }

        public bool Diferite { get; set; }

        public Guid TreningId { get; set; }

        [ForeignKey("TreningId")]
        public Trening Trening { get; set; }
    }
}
