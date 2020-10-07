using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class SbsecDeleted
    {
        public decimal Ndealkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Ccurrcode { get; set; }
        public string Cseccode { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Cclientcode { get; set; }
        public string Cbookcode { get; set; }
        public string Cdealercode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Copcode { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nsumnom { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nsumkup { get; set; }
        public decimal? Nfullsum { get; set; }
        public DateTime? Ddeliverydate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nexcom { get; set; }
        public decimal? Nbankcom { get; set; }
        public decimal? Nprice { get; set; }
        public decimal? Nsalescredit { get; set; }
        public decimal? Nsalescreditsum { get; set; }
        public string Csalescreditcurr { get; set; }
        public decimal? Namount { get; set; }
        public decimal? Bnocurrpaym { get; set; }
        public decimal? Bnoreserv { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nplpct { get; set; }
        public decimal? Bnetting { get; set; }
        public decimal? Nsumput { get; set; }
        public decimal? Bminusport { get; set; }
        public string Ccomment { get; set; }
        public string Csettlementtype { get; set; }
        public decimal? Icrsstatus { get; set; }
        public decimal? Nsalespersonid { get; set; }
        public string Csalescreditcomment { get; set; }
        public decimal? Nsalesrate { get; set; }
        public string Csummitstatus { get; set; }
        public int? Ntradenum { get; set; }
        public bool? Bbrokerage { get; set; }
        public decimal? Ntranshkey { get; set; }
        public string Ctradetime { get; set; }
        public string Ccpclientcode { get; set; }
        public string Ctradeplace { get; set; }
        public bool? Bnosummit { get; set; }
        public decimal? Nbrokerkey { get; set; }
        public decimal? Nmarkup { get; set; }
        public DateTime? Daudittimestamp { get; set; }
        public bool? Bnocrs { get; set; }
        public decimal? Ninternalkey { get; set; }
        public bool? Binternal { get; set; }
        public bool? Bautoprint { get; set; }
        public decimal? Norderkey { get; set; }
        public string Csettplace { get; set; }
        public decimal? Ncounteracc { get; set; }
        public decimal? Nacckey { get; set; }
        public string Csetlcurr { get; set; }
        public DateTime? Dcontrfulldate { get; set; }
        public string Cbrief { get; set; }
        public decimal? Nrate { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Dealers CdealercodeNavigation { get; set; }
    }
}
