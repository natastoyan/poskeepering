using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Yieldperiods
    {
        public string Cperiodcode { get; set; }
        public decimal? Icount { get; set; }
        public decimal? Itype { get; set; }
        public decimal? Idaysfrom { get; set; }
        public decimal? Idaysto { get; set; }
        public decimal? Iorder { get; set; }
    }
}
