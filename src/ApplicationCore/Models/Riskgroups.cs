using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Riskgroups
    {
        public Riskgroups()
        {
            Counterlimits = new HashSet<Counterlimits>();
            Periodstoproducts = new HashSet<Periodstoproducts>();
            Riskcrosslimit = new HashSet<Riskcrosslimit>();
            Subperioddays = new HashSet<Subperioddays>();
            Subriskgroups = new HashSet<Subriskgroups>();
        }

        public string Criskgroupcode { get; set; }
        public string Cgroupriskcomment { get; set; }
        public decimal? Iorder { get; set; }

        public virtual ICollection<Counterlimits> Counterlimits { get; set; }
        public virtual ICollection<Periodstoproducts> Periodstoproducts { get; set; }
        public virtual ICollection<Riskcrosslimit> Riskcrosslimit { get; set; }
        public virtual ICollection<Subperioddays> Subperioddays { get; set; }
        public virtual ICollection<Subriskgroups> Subriskgroups { get; set; }
    }
}
