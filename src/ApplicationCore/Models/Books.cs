using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Books
    {
        public Books()
        {
            Depo = new HashSet<Depo>();
            Forex = new HashSet<Forex>();
            Netting = new HashSet<Netting>();
            Recres = new HashSet<Recres>();
            RepoOld = new HashSet<RepoOld>();
            SbsecDeleted = new HashSet<SbsecDeleted>();
            Swap = new HashSet<Swap>();
            Trans = new HashSet<Trans>();
        }

        public string Cbookcode { get; set; }
        public string Cbookname { get; set; }
        public string Csummitbookcode { get; set; }
        public string Cdealercode { get; set; }
        public string Csummitdeskcode { get; set; }
        public string Cathenabookcode { get; set; }
        public string Catlasbookcode { get; set; }
        public bool? Batlasexport { get; set; }
        public string Ccompany { get; set; }
        public bool? Bcrsexport { get; set; }
        public bool? Bsummitexport { get; set; }
        public string Ccounterparty { get; set; }
        public string Cdiasoftbookcode { get; set; }
        public bool? Bactive { get; set; }
        public bool? Bathenaintexport { get; set; }
        public string Ccrsbookcode { get; set; }
        public string Cblomberglogin { get; set; }
        public string Cblombergbook { get; set; }
        public bool? Bprintmmdepartment { get; set; }

        public virtual Orgs CcounterpartyNavigation { get; set; }
        public virtual ICollection<Depo> Depo { get; set; }
        public virtual ICollection<Forex> Forex { get; set; }
        public virtual ICollection<Netting> Netting { get; set; }
        public virtual ICollection<Recres> Recres { get; set; }
        public virtual ICollection<RepoOld> RepoOld { get; set; }
        public virtual ICollection<SbsecDeleted> SbsecDeleted { get; set; }
        public virtual ICollection<Swap> Swap { get; set; }
        public virtual ICollection<Trans> Trans { get; set; }
    }
}
