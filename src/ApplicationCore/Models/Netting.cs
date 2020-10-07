using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Netting
    {
        public decimal Ndealkey { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public string Ccontrcode { get; set; }
        public string Copcode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public string Cbookcode { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Currency CcurrcodeNavigation { get; set; }
    }
}
