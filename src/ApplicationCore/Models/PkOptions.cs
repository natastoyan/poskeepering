using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkOptions
    {
        public decimal Noptionskey { get; set; }
        public string Creuterimpdir { get; set; }
        public decimal? Breutermsmq { get; set; }
        public decimal? Breutermasync { get; set; }
        public string Creuinqueue { get; set; }
        public string Creuoutqueue { get; set; }
        public string Csummitexpdir { get; set; }
        public string Cdeftrader { get; set; }
        public string Csummitimpdir { get; set; }
        public string Cathenaexpdir { get; set; }
        public string Cathenaflag { get; set; }
        public string Cbookingbranch { get; set; }
        public string Ccrsexportdatadirectory { get; set; }
        public string Ccrsimportdatadirectory { get; set; }
        public string Ccrsflag { get; set; }
        public DateTime? Dlastclientimport { get; set; }
        public string Cvtmcurrency { get; set; }
        public string Cdiasoftexpdir { get; set; }
        public string Cdiasoftimpdir { get; set; }
        public string Cathenarateimportdir { get; set; }
        public string Cermsexpdir { get; set; }
        public string Cermsimpdir { get; set; }
        public string Cplcalcmethod { get; set; }
        public string Cdefprinter { get; set; }
        public bool? Brepdefprinter { get; set; }
        public string Cbookforreport { get; set; }
        public bool? Bautodefprinter { get; set; }
        public string Cmicexfxcontr { get; set; }
        public decimal? Nswapnumber { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
        public bool? BautodefprinterRepo { get; set; }
        public string CdefprinterRepo { get; set; }
        public string CdefprinterMmdp { get; set; }
        public decimal? BautodefprinterMmdp { get; set; }
        public decimal? Nloadrows { get; set; }
    }
}
