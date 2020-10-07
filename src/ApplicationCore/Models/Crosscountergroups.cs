using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Crosscountergroups
    {
        public Crosscountergroups()
        {
            Counterlimits = new HashSet<Counterlimits>();
            Riskcrosslimit = new HashSet<Riskcrosslimit>();
        }

        public string Ccrossgroupcode { get; set; }
        public string Ccrossgroupcomment { get; set; }

        public virtual ICollection<Counterlimits> Counterlimits { get; set; }
        public virtual ICollection<Riskcrosslimit> Riskcrosslimit { get; set; }
    }
}
