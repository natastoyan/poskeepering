using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Quikerrors
    {
        public decimal? Nkey { get; set; }
        public DateTime? Ddate { get; set; }
        public string Csource { get; set; }
        public string Cerror { get; set; }
        public decimal? Ntradenum { get; set; }
        public bool? Bprocess { get; set; }
    }
}
