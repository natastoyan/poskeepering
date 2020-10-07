using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Operation
    {
        public Operation()
        {
            Limitweightrisk = new HashSet<Limitweightrisk>();
            Mappingproducts = new HashSet<Mappingproducts>();
            Recres = new HashSet<Recres>();
            RepoOld = new HashSet<RepoOld>();
            RurrepoOld = new HashSet<RurrepoOld>();
            Swap = new HashSet<Swap>();
            Trans = new HashSet<Trans>();
        }

        public string Copcode { get; set; }
        public string Copname { get; set; }
        public string Ccomment { get; set; }
        public string Ccurracctype { get; set; }

        public virtual ICollection<Limitweightrisk> Limitweightrisk { get; set; }
        public virtual ICollection<Mappingproducts> Mappingproducts { get; set; }
        public virtual ICollection<Recres> Recres { get; set; }
        public virtual ICollection<RepoOld> RepoOld { get; set; }
        public virtual ICollection<RurrepoOld> RurrepoOld { get; set; }
        public virtual ICollection<Swap> Swap { get; set; }
        public virtual ICollection<Trans> Trans { get; set; }
    }
}
