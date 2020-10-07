using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Fvsupdates
    {
        public decimal Nupdatekey { get; set; }
        public string Cupdatename { get; set; }
        public DateTime? Dupdatedate { get; set; }
        public DateTime? Dupdatecommit { get; set; }
        public string Cupdatetype { get; set; }
    }
}
