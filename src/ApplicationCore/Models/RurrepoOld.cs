using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class RurrepoOld
    {
        public RurrepoOld()
        {
            Rurreposums = new HashSet<Rurreposums>();
        }

        public decimal Ndealkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Cseccode { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Cclientcode { get; set; }
        public string Ccontrcode { get; set; }
        public string Cbookcode { get; set; }
        public string Copcode { get; set; }
        public string Cdealercode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsumnom { get; set; }
        public decimal? Isb { get; set; }
        public decimal? Nmarketsum { get; set; }
        public DateTime? Dstartdate { get; set; }
        public DateTime? Dclosedate { get; set; }
        public decimal? Nreposum { get; set; }
        public string Creporate { get; set; }
        public decimal? Nreposum2 { get; set; }
        public decimal? Nsumkup { get; set; }
        public decimal? Nsumkup2 { get; set; }
        public decimal? Nheircut { get; set; }
        public decimal? Irepobase { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Nplpct { get; set; }
        public decimal? Nstep { get; set; }
        public decimal? Bnetting { get; set; }
        public decimal? Bopenpos { get; set; }
        public decimal? Nprice { get; set; }
        public decimal? Nprice2 { get; set; }
        public decimal? Nmarketsum2 { get; set; }
        public decimal? Icrsstatus { get; set; }
        public string Csettlementtype { get; set; }
        public string Csummitstatus { get; set; }
        public string Creutersimportfile { get; set; }
        public int? Ntradenum { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nequitykey { get; set; }
        public bool? Bnosummit { get; set; }
        public bool? Bnocrs { get; set; }
        public decimal? Ninternalkey { get; set; }
        public bool? Binternal { get; set; }
        public DateTime? Daudittimestamp { get; set; }
        public decimal? Nupperdiscount { get; set; }
        public decimal? Nlowerdiscount { get; set; }
        public string Ccpclientcode { get; set; }
        public decimal? Bbrokerage { get; set; }

        public virtual Operation CopcodeNavigation { get; set; }
        public virtual ICollection<Rurreposums> Rurreposums { get; set; }
    }
}
