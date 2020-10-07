using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VCurrpaym
    {
        public decimal? Ncurrpaymkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cpaymtypecode { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Copcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Ndealkey { get; set; }
        public DateTime? Ddealdatetime { get; set; }
        public string Cusername { get; set; }
        public decimal? Bstorno { get; set; }
        public bool? Isb { get; set; }
        public string Cnettcode { get; set; }
        public bool? Bnetting { get; set; }
        public decimal? Btrueflag { get; set; }
        public decimal? Nclcorr { get; set; }
        public decimal? Nremocp { get; set; }
        public decimal? Nremliq { get; set; }
        public decimal? Nsettcred { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public decimal? Nmurexoid { get; set; }
        public string Cdealercode { get; set; }
        public string Ccounter { get; set; }
        public decimal? Nposorder { get; set; }
        public decimal? Bpos { get; set; }
    }
}
