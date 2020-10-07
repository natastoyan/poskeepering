using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class EquitingdealsAudit
    {
        public decimal? Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public decimal? Nequitykey { get; set; }
        public bool? Isb { get; set; }
        public DateTime? Dtradedate { get; set; }
        public string Ctradetime { get; set; }
        public DateTime? Deqsettldate { get; set; }
        public DateTime? Dcashsettldate { get; set; }
        public string Corgcode { get; set; }
        public decimal? Nquantity { get; set; }
        public decimal? Nprice { get; set; }
        public string Ctradecurrcode { get; set; }
        public string Csettlcurrcode { get; set; }
        public decimal? Nprincipalamount { get; set; }
        public decimal? Ntotalamount { get; set; }
        public decimal? Ncomission { get; set; }
        public bool? Bcommpct { get; set; }
        public decimal? Ncharges { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nsalescredit { get; set; }
        public string Csalescreditcurr { get; set; }
        public decimal? Nsalescreditsum { get; set; }
        public string Cbookcode { get; set; }
        public string Cdealercode { get; set; }
        public string Cnetgross { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Csettlmenttype { get; set; }
        public decimal? Icrsstatus { get; set; }
        public bool? Btruecashsettl { get; set; }
        public bool? Btrueeqsettl { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Ntradeprice { get; set; }
        public DateTime? Dagreementdate { get; set; }
        public DateTime? Dchangedatetime { get; set; }
        public decimal? Nchangereason { get; set; }
        public string Camendcomment { get; set; }
        public string Ctradeplace { get; set; }
        public string Caccount { get; set; }
        public decimal? Cordernum { get; set; }
        public bool? Btrueagredate { get; set; }
        public string Csettlecode { get; set; }
        public decimal? Nsalespersonid { get; set; }
        public string Ccporgcode { get; set; }
        public bool? Ibd { get; set; }
        public string Cdiasoftstatus { get; set; }
        public decimal? Csecondref { get; set; }
        public decimal? Nversion { get; set; }
        public string Cclientcode { get; set; }
        public string Cstatusrec { get; set; }
        public bool? Bcpclient { get; set; }
        public DateTime? Dregtime { get; set; }
        public decimal? Ndayinc { get; set; }
        public bool? Binternal { get; set; }
        public decimal? Ninternalkey { get; set; }
        public decimal? Norderkey { get; set; }
        public decimal? Ntradenum { get; set; }
        public string Cfidessaid { get; set; }
        public decimal? Nfidessaversion { get; set; }
        public string Cinsttype { get; set; }
        public string Csetlplace { get; set; }
        public bool? Bsenttodiasoft { get; set; }
    }
}
