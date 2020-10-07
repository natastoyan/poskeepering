using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqrecres
    {
        public decimal Ndealkey { get; set; }
        public decimal Nequitykey { get; set; }
        public decimal? Nquantity { get; set; }
        public DateTime Ddate { get; set; }
        public bool Ies { get; set; }
        public string Cbookcode { get; set; }
        public string Csettlplace { get; set; }
        public bool? Isb { get; set; }
        public DateTime? Dregdate { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nsecrecres { get; set; }
        public string Ctradecurrcode { get; set; }
    }
}
