using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Availablecolumntypes
    {
        public Availablecolumntypes()
        {
            Availablecolumns = new HashSet<Availablecolumns>();
        }

        public string Cavailcoltypecode { get; set; }

        public virtual ICollection<Availablecolumns> Availablecolumns { get; set; }
    }
}
