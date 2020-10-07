using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VBookdeals
    {
        public string Copcode { get; set; }
        public decimal? Ndealkey { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public string Cdealnumber { get; set; }
        public string Cticket { get; set; }
        public string Cbookcode { get; set; }
        public string Cathenabookcode { get; set; }
        public string Ccontrcode { get; set; }
        public decimal? Nsum1 { get; set; }
        public decimal? Nsum2 { get; set; }
        public decimal? Nrate { get; set; }
        public string Ccurrcode { get; set; }
        public string Ctype { get; set; }
    }
}
