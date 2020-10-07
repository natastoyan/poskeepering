using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Pricesource
    {
        public Pricesource()
        {
            Rates = new HashSet<Rates>();
            Secprice = new HashSet<Secprice>();
        }

        public string Csourcecode { get; set; }
        public string Csourcename { get; set; }

        public virtual ICollection<Rates> Rates { get; set; }
        public virtual ICollection<Secprice> Secprice { get; set; }
    }
}
