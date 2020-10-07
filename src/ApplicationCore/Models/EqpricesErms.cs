using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class EqpricesErms
    {
        public decimal Nequitykey { get; set; }
        public DateTime Ddate { get; set; }
        public string Cdiasoftcode { get; set; }
        public decimal? Nprice { get; set; }
        public string Ccurr { get; set; }

        public virtual Eqproducts NequitykeyNavigation { get; set; }
    }
}
