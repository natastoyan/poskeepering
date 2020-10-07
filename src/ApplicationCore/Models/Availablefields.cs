using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Availablefields
    {
        public Availablefields()
        {
            Selectcondsline = new HashSet<Selectcondsline>();
        }

        public decimal Navailfkey { get; set; }
        public string Cavailtypecode { get; set; }
        public decimal? Nclassifkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public string Cavailfname { get; set; }
        public string Cfield { get; set; }
        public string Clookuptable { get; set; }
        public string Clookupfield { get; set; }
        public string Cdict { get; set; }
        public string Ccrystalexpr { get; set; }

        public virtual Availablefieldtypes CavailtypecodeNavigation { get; set; }
        public virtual Dictname NclassifkeyNavigation { get; set; }
        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Selectcondsline> Selectcondsline { get; set; }
    }
}
