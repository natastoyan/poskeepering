using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Subperiods
    {
        public Subperiods()
        {
            Counterlimits = new HashSet<Counterlimits>();
        }

        public string Csubperiodcode { get; set; }
        public string Cperiodcode { get; set; }
        public decimal? Iorder { get; set; }

        public virtual Riskperiodscodes CperiodcodeNavigation { get; set; }
        public virtual ICollection<Counterlimits> Counterlimits { get; set; }
    }
}
