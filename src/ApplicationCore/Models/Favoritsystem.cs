using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Favoritsystem
    {
        public Favoritsystem()
        {
            Roles = new HashSet<Roles>();
        }

        public decimal Nsystemkey { get; set; }
        public string Csystemcode { get; set; }
        public string Csystemname { get; set; }
        public decimal? Bmandatory { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
    }
}
