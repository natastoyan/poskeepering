using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Swap
    {
        public decimal Ndealkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cpair { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Cclientcode { get; set; }
        public string Cdepartcode { get; set; }
        public string Cdealercode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Cticket { get; set; }
        public string Copcode { get; set; }
        public decimal? Binternal { get; set; }
        public string Cbookcode { get; set; }
        public string Cfixcurrcode { get; set; }
        public string Ccurrcodeb { get; set; }
        public string Ccurrcodes { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nsums { get; set; }
        public decimal? Nsumb2 { get; set; }
        public decimal? Nrate2 { get; set; }
        public decimal? Nsums2 { get; set; }
        public string Cswaprate { get; set; }
        public DateTime? Dvaluedateb { get; set; }
        public DateTime? Dvaluedates { get; set; }
        public DateTime? Dvaluedateb2 { get; set; }
        public DateTime? Dvaluedates2 { get; set; }
        public decimal? Iperiod { get; set; }
        public decimal? Bnettingb { get; set; }
        public decimal? Bnettings { get; set; }
        public decimal? Bnettingb2 { get; set; }
        public decimal? Bnettings2 { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nplpct { get; set; }
        public decimal? Nswaprate { get; set; }
        public decimal? Ndeporate { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Currency CcurrcodebNavigation { get; set; }
        public virtual Currency CcurrcodesNavigation { get; set; }
        public virtual Dealers CdealercodeNavigation { get; set; }
        public virtual Currency CfixcurrcodeNavigation { get; set; }
        public virtual Operation CopcodeNavigation { get; set; }
        public virtual Currpair CpairNavigation { get; set; }
    }
}
