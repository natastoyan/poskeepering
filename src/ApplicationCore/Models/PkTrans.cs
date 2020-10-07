using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkTrans
    {
        public decimal? Ndealkey { get; set; }
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
        public string Cpaympurpose { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nsendathene { get; set; }
        public DateTime? Dsenddate { get; set; }
        public bool? Bsendntfy { get; set; }
        public string Cmail { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
