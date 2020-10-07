using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Dictname
    {
        public Dictname()
        {
            Availablefields = new HashSet<Availablefields>();
        }

        public decimal Nclassifkey { get; set; }
        public string Cclassifname { get; set; }

        public virtual ICollection<Availablefields> Availablefields { get; set; }
    }
}
