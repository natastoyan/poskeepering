using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Availablegroups
    {
        public Availablegroups()
        {
            Groupcondsline = new HashSet<Groupcondsline>();
        }

        public decimal Navalgrkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public string Cavailgrname { get; set; }
        public string Cfield { get; set; }

        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Groupcondsline> Groupcondsline { get; set; }
    }
}
