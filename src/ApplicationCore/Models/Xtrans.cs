using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Xtrans
    {
        public decimal Ndealkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public string Ccodefrom { get; set; }
        public string Ccodeto { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Copcode { get; set; }
        public string Cbookcode { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nacckeyfrom { get; set; }
        public decimal? Nacckeyto { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Ilogverify { get; set; }
        public string Cpaympurpose { get; set; }
        public string Cnameto { get; set; }
        public string Cnamefrom { get; set; }
        public string Ccorrcodeto { get; set; }
        public string Ccorrcodefrom { get; set; }
        public string Caccto { get; set; }
        public string Caccfrom { get; set; }
        public string Ccorrnameto { get; set; }
        public string Ccorrnamefrom { get; set; }
        public string Cbicfrom { get; set; }
        public string Cbicto { get; set; }
        public string Cinnfrom { get; set; }
        public string Cinnto { get; set; }
        public string Caccbalfrom { get; set; }
        public string Caccbalto { get; set; }
        public string Cpaymforinter { get; set; }
        public string Creqfrom { get; set; }
        public string Creqto { get; set; }
        public decimal? Nsendathene { get; set; }
        public bool? Burgentpayment { get; set; }
        public string Creportcomment { get; set; }
        public string Cathenastatus { get; set; }
        public DateTime? Cathenaexportdate { get; set; }
    }
}
