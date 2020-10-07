using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Secacctypes
    {
        public Secacctypes()
        {
            Secacc = new HashSet<Secacc>();
        }

        public string Csecacccode { get; set; }
        public string Csecaccname { get; set; }

        public virtual ICollection<Secacc> Secacc { get; set; }
    }
}
