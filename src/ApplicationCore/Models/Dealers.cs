using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Dealers
    {
        public Dealers()
        {
            Depo = new HashSet<Depo>();
            Forex = new HashSet<Forex>();
            RepoOld = new HashSet<RepoOld>();
            SbsecDeleted = new HashSet<SbsecDeleted>();
            Swap = new HashSet<Swap>();
        }

        public string Cdealercode { get; set; }
        public string Cdealername { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public string Creutercode { get; set; }
        public string Cmicexcode { get; set; }
        public string Cquikid { get; set; }
        public string Cusername { get; set; }
        public string Cquikclientcode { get; set; }
        public string Cnamerus { get; set; }
        public string Cbbgid { get; set; }

        public virtual ICollection<Depo> Depo { get; set; }
        public virtual ICollection<Forex> Forex { get; set; }
        public virtual ICollection<RepoOld> RepoOld { get; set; }
        public virtual ICollection<SbsecDeleted> SbsecDeleted { get; set; }
        public virtual ICollection<Swap> Swap { get; set; }
    }
}
