using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class TmpRemains
    {
        public decimal? Nacckey { get; set; }
        public string Ccurrcode { get; set; }
        public string Copcode { get; set; }
        public decimal? Nsum { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Oldndealkey { get; set; }
        public string Oldcopcode { get; set; }
        public decimal? Oldnsum { get; set; }
        public decimal? Newndealkey { get; set; }
        public decimal? Newnsum { get; set; }
        public string Newcopcode { get; set; }
    }
}
