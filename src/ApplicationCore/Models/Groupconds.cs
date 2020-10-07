using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Groupconds
    {
        public Groupconds()
        {
            Customreports = new HashSet<Customreports>();
            Groupcondsline = new HashSet<Groupcondsline>();
        }

        public decimal Ngroupcondkey { get; set; }
        public string Cgroupcondname { get; set; }
        public decimal? Nrepkey { get; set; }

        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Customreports> Customreports { get; set; }
        public virtual ICollection<Groupcondsline> Groupcondsline { get; set; }
    }
}
