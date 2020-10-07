using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currratehist
    {
        public decimal Nchangekey { get; set; }
        public DateTime? Ddate { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Ccurr1 { get; set; }
        public string Ccurr2 { get; set; }
        public decimal? Nboside { get; set; }
        public decimal? Nvalue { get; set; }
        public decimal? Nservreqkey { get; set; }
        public bool? Iatm { get; set; }
    }
}
