using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Orgstype
    {
        public Orgstype()
        {
            Orgs = new HashSet<Orgs>();
        }

        public string Corgtypecode { get; set; }
        public string Corgtypename { get; set; }
        public string Orgname { get; set; }

        public virtual ICollection<Orgs> Orgs { get; set; }
    }
}
