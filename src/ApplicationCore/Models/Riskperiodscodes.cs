using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Riskperiodscodes
    {
        public Riskperiodscodes()
        {
            Counterlimits = new HashSet<Counterlimits>();
            Periodstoproducts = new HashSet<Periodstoproducts>();
            Subperiods = new HashSet<Subperiods>();
        }

        public string Cperiodcode { get; set; }
        public string Cperiodcomment { get; set; }
        public decimal? Iorder { get; set; }

        public virtual ICollection<Counterlimits> Counterlimits { get; set; }
        public virtual ICollection<Periodstoproducts> Periodstoproducts { get; set; }
        public virtual ICollection<Subperiods> Subperiods { get; set; }
    }
}
