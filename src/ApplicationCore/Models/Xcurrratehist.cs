using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Xcurrratehist
    {
        public decimal Nchangekey { get; set; }
        public DateTime? Ddate { get; set; }
        public string Cdate { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Cusername { get; set; }
        public string Ccurr1 { get; set; }
        public string Ccurr2 { get; set; }
        public decimal? Nboside { get; set; }
        public string Cboside { get; set; }
        public decimal? Nnewvalue { get; set; }
        public decimal? Noldvalue { get; set; }
        public string Cservreqstatus { get; set; }
        public string Ccomment { get; set; }
    }
}
