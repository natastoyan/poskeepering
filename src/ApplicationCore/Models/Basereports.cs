using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Basereports
    {
        public Basereports()
        {
            Availablecolumns = new HashSet<Availablecolumns>();
            Availablefields = new HashSet<Availablefields>();
            Availablegroups = new HashSet<Availablegroups>();
            Columnlists = new HashSet<Columnlists>();
            Customreports = new HashSet<Customreports>();
            Groupconds = new HashSet<Groupconds>();
            Selectconds = new HashSet<Selectconds>();
        }

        public decimal Nrepkey { get; set; }
        public string Crepname { get; set; }
        public string Ctable { get; set; }
        public string Ccrystalfile { get; set; }
        public string Cexcelfile { get; set; }
        public decimal? Nactivevar { get; set; }

        public virtual ICollection<Availablecolumns> Availablecolumns { get; set; }
        public virtual ICollection<Availablefields> Availablefields { get; set; }
        public virtual ICollection<Availablegroups> Availablegroups { get; set; }
        public virtual ICollection<Columnlists> Columnlists { get; set; }
        public virtual ICollection<Customreports> Customreports { get; set; }
        public virtual ICollection<Groupconds> Groupconds { get; set; }
        public virtual ICollection<Selectconds> Selectconds { get; set; }
    }
}
