using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Availablecolumns
    {
        public Availablecolumns()
        {
            Collistline = new HashSet<Collistline>();
        }

        public decimal Navailcolkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public string Cavailcoltypecode { get; set; }
        public string Cavailcolname { get; set; }
        public string Cfield { get; set; }

        public virtual Availablecolumntypes CavailcoltypecodeNavigation { get; set; }
        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Collistline> Collistline { get; set; }
    }
}
