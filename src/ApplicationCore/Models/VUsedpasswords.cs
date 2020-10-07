using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VUsedpasswords
    {
        public string Owner { get; set; }
        public decimal? Nuserkey { get; set; }
        public string Cpasswd { get; set; }
        public DateTime? Denddate { get; set; }
    }
}
