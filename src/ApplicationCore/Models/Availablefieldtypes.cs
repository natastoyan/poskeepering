using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Availablefieldtypes
    {
        public Availablefieldtypes()
        {
            Availablefields = new HashSet<Availablefields>();
        }

        public string Cavailtypecode { get; set; }

        public virtual ICollection<Availablefields> Availablefields { get; set; }
    }
}
