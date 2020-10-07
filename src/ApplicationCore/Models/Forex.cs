using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public partial class Forex: BaseIntIdModel
    {
      //  [Key]
      //  public decimal Ndealkey { get; set; }
      [Key]
      public decimal Id { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public DateTime? Dregdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Cclientcode { get; set; }
        public string Cdepartcode { get; set; }
        public string Copcode { get; set; }
        public string Cbookcode { get; set; }
        public string Cdealercode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Cticket { get; set; }
        public string Ctype { get; set; }
        public string Ccurrcodeb { get; set; }
        public string Ccurrcodes { get; set; }
        public decimal? Nsumb { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nsums { get; set; }
        public DateTime? Dvaluedateb { get; set; }
        public DateTime? Dvaluedates { get; set; }
        public decimal? Bnettingb { get; set; }
        public decimal? Bnettings { get; set; }
        public decimal? Bvcflag { get; set; }
        public decimal? Nsalescredit { get; set; }
        public decimal? Nsalescreditsum { get; set; }
        public string Csalescreditcurr { get; set; }
        public string Cpair { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nfixrate { get; set; }
        public decimal? Nfixsum { get; set; }
        public string Cfixcurr { get; set; }
        public decimal? Nfixdeal { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Nplpct { get; set; }
        public string Cndfticket { get; set; }
        public decimal? Bndfnetting { get; set; }
        public string Cbrokcode { get; set; }
        public string Cbrokcurrcode { get; set; }
        public decimal? Nbrokcom { get; set; }
        public string Cimportfile { get; set; }
        public decimal? Ireuterimpflag { get; set; }
        public decimal? Bsummitexported { get; set; }
        public DateTime? Dtimestamp { get; set; }
        public string Cpiemessageid { get; set; }
        public decimal? Bexcltradepos { get; set; }
        public string Creuterscontr { get; set; }
        public decimal? Imatchathena { get; set; }
        public decimal? Icrsstatus { get; set; }
        public string Csettlementtype { get; set; }
        public string Csalescreditcomment { get; set; }
        public decimal? Nsalespersonid { get; set; }
        public decimal? Nsalesrate { get; set; }
        public bool? Bathenaimported { get; set; }
        public decimal? Nahenaclassified { get; set; }
        public DateTime? Daudittimestamp { get; set; }
        public string Csummitstatus { get; set; }
        public decimal? Ninternalkey { get; set; }
        public bool? Binternal { get; set; }
        public bool? Bswap { get; set; }
        public string Csource { get; set; }
        public decimal? Ntradenum { get; set; }
        public string Ccomment { get; set; }
        public bool? Bnosummit { get; set; }
        public bool? Bautoprint { get; set; }
        public decimal? Nfxcount { get; set; }
        public string Ctradevenue { get; set; }
        public bool? Bnocrs { get; set; }
        public bool? Iswaptype { get; set; }
        public string Cfirmid { get; set; }
        public bool? Bdraftdeal { get; set; }
        public decimal? Nswapkey { get; set; }
        public bool? Bnoexchtrans { get; set; }
        public bool? Bkeeprubpaym { get; set; }
        public decimal? Nmurexid { get; set; }
        public decimal? Nmurexoid { get; set; }
        public string Cbktcurrcode { get; set; }
        public decimal? Nswapfwdday { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Currency CcurrcodebNavigation { get; set; }
        public virtual Currency CcurrcodesNavigation { get; set; }
        public virtual Dealers CdealercodeNavigation { get; set; }
        public virtual Currency CsalescreditcurrNavigation { get; set; }
    }
}
