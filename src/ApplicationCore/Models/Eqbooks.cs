using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqbooks
    {
        public Eqbooks()
        {
            Equitingdeals = new HashSet<Equitingdeals>();
        }

        public string Cbookcode { get; set; }
        public string Cbookname { get; set; }
        public bool? Bbrokerage { get; set; }
        public string Ccrsbookcode { get; set; }

        public virtual ICollection<Equitingdeals> Equitingdeals { get; set; }
    }
}
