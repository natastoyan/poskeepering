using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currpaym
    {
        public decimal Ncurrpaymkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cpaymtypecode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Copcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndealkey { get; set; }
        public decimal? Bstorno { get; set; }
        public bool? Isb { get; set; }
        public string Cnettcode { get; set; }
        public bool? Bnetting { get; set; }
        public decimal? Btrueflag { get; set; }
        public decimal? Nclcorr { get; set; }
        public decimal? Nremocp { get; set; }
        public decimal? Nremliq { get; set; }
        public decimal? Nsettcred { get; set; }
        public decimal? Imatchathena { get; set; }

        public virtual CurraccOld NacckeyNavigation { get; set; }
    }
}
