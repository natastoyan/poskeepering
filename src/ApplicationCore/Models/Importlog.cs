using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Importlog
    {
        public DateTime? Ddate { get; set; }
        public string Cfilename { get; set; }
        public string Ctext { get; set; }
    }
}
