using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Fxsumsell
    {
        public DateTime? Dvaluedate { get; set; }
        public decimal? Nsum { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dcontrdate { get; set; }
        public string Cbookcode { get; set; }
    }
}
