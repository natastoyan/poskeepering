using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkCurrpaym
    {
        public decimal? Ndealkey { get; set; }
        public decimal? Ncurrpaymkey { get; set; }
        public string Cpaymtypecode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Copcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Bstorno { get; set; }
        public bool? Isb { get; set; }
        public string Cnettcode { get; set; }
        public bool? Bnetting { get; set; }
        public decimal? Btrueflag { get; set; }
        public decimal? Nclcorr { get; set; }
        public decimal? Nremocp { get; set; }
        public decimal? Nremliq { get; set; }
        public decimal? Nsettcred { get; set; }
        public decimal? Nlogreckey { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime? DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public bool? Imatchathena { get; set; }
    }
}
