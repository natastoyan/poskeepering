using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Dayperiods
    {
        public DateTime? Ddate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Ialg { get; set; }
        public string Ccode { get; set; }
        public DateTime? Ddatefrom { get; set; }
        public DateTime? Ddateto { get; set; }
        public decimal? Iclass { get; set; }
        public decimal? Inumber { get; set; }
        public decimal? Ispos { get; set; }
        public decimal Nkey { get; set; }
        public decimal? Nact { get; set; }
        public decimal? Navgact { get; set; }
        public decimal? Npass { get; set; }
        public decimal? Navgpass { get; set; }
        public decimal? Nactsum { get; set; }
        public decimal? Navgactsum { get; set; }
        public decimal? Npasssum { get; set; }
        public decimal? Navgpasssum { get; set; }
        public decimal? Nactsum2 { get; set; }
        public decimal? Navgactsum2 { get; set; }
        public decimal? Npasssum2 { get; set; }
        public decimal? Navgpasssum2 { get; set; }
    }
}
