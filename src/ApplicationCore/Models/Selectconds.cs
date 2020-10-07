using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Selectconds
    {
        public Selectconds()
        {
            Customreports = new HashSet<Customreports>();
            Filters = new HashSet<Filters>();
            Selectcondsline = new HashSet<Selectcondsline>();
        }

        public decimal Nselectcondkey { get; set; }
        public string Cselectcondname { get; set; }
        public decimal? Nrepkey { get; set; }
        public decimal? Nuserkey { get; set; }
        public decimal? Bdefault { get; set; }

        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Customreports> Customreports { get; set; }
        public virtual ICollection<Filters> Filters { get; set; }
        public virtual ICollection<Selectcondsline> Selectcondsline { get; set; }
    }
}
