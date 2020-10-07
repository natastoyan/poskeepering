using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Curraccdefault
    {
        public string Copcode { get; set; }
        public string Cacctypecode { get; set; }
        public decimal? Nacckey { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Bbrok { get; set; }
        public string Ctradeplace { get; set; }
        public string Csetltype { get; set; }
        public string Csectype { get; set; }
        public string Csetlplace { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Nsourcekey { get; set; }

        public virtual Curracctypes CacctypecodeNavigation { get; set; }
        public virtual Operation CopcodeNavigation { get; set; }
    }
}
