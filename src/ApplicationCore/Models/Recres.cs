using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Recres
    {
        public decimal Ndealkey { get; set; }
        public decimal? Nlogreckey { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsourcekey { get; set; }
        public string Copcode { get; set; }
        public string Cbookcode { get; set; }
        public string Ccorrcode { get; set; }
        public string Cdealnumber { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Isb { get; set; }
        public string Cclientcode { get; set; }
        public string Cdepartkey { get; set; }
        public string Ccomment { get; set; }
        public string Crecrestypecode { get; set; }
        public decimal? Nacckey { get; set; }
        public decimal? Bocp { get; set; }
        public bool? Bextended { get; set; }
        public bool? Binternal { get; set; }
        public bool? Bconfirmed { get; set; }
        public decimal? Nloguserkey { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Currency CcurrcodeNavigation { get; set; }
        public virtual Operation CopcodeNavigation { get; set; }
        public virtual Logrecord NlogreckeyNavigation { get; set; }
    }
}
