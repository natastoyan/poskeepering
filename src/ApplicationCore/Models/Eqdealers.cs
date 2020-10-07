using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqdealers
    {
        public Eqdealers()
        {
            Equitingdeals = new HashSet<Equitingdeals>();
        }

        public string Ccode { get; set; }
        public string Cname { get; set; }
        public string Ctradeplace { get; set; }
        public string Ctradecode { get; set; }
        public bool? Bactive { get; set; }

        public virtual ICollection<Equitingdeals> Equitingdeals { get; set; }
    }
}
