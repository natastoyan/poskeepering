using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Secaccdefault
    {
        public string Copcode { get; set; }
        public string Csecacccode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Cseccode { get; set; }

        public virtual Operation CopcodeNavigation { get; set; }
        public virtual Secacctypes CsecacccodeNavigation { get; set; }
        public virtual Secacc NacckeyNavigation { get; set; }
    }
}
