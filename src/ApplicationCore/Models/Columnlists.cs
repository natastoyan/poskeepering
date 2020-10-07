using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Columnlists
    {
        public Columnlists()
        {
            Collistline = new HashSet<Collistline>();
            Customreports = new HashSet<Customreports>();
        }

        public decimal Ncollistkey { get; set; }
        public decimal? Nrepkey { get; set; }
        public string Ccollistname { get; set; }

        public virtual Basereports NrepkeyNavigation { get; set; }
        public virtual ICollection<Collistline> Collistline { get; set; }
        public virtual ICollection<Customreports> Customreports { get; set; }
    }
}
