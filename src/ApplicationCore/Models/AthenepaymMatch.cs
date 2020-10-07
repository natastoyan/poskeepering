using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class AthenepaymMatch
    {
        public decimal? Nmurexid { get; set; }
        public decimal? Ngridid { get; set; }
        public string Ccontrcode { get; set; }
        public string Cacc { get; set; }
        public string Ccurrcode { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public decimal? Imatchathena { get; set; }
        public decimal? Nsum { get; set; }
    }
}
