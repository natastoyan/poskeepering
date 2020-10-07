using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Reposums
    {
        public decimal Nreposumkey { get; set; }
        public string Cseccode { get; set; }
        public DateTime? Dmaturitydate { get; set; }
        public string Ccouponrate { get; set; }
        public decimal? Ndealkey { get; set; }
        public decimal? Nsumnom { get; set; }
        public decimal? Nprice { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Icrsstatus { get; set; }
        public decimal? Ntranshkey { get; set; }
        public decimal? Ninternalkey { get; set; }
        public bool? Binternal { get; set; }

        public virtual RepoOld NdealkeyNavigation { get; set; }
    }
}
