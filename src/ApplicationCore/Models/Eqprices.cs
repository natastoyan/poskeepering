using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqprices
    {
        public decimal Nequitykey { get; set; }
        public DateTime Ddate { get; set; }
        public string Cclasscode { get; set; }
        public decimal? Nmarketprice { get; set; }
        public string Csecurcode { get; set; }
        public string Ccurrcode { get; set; }

        public virtual Eqproducts NequitykeyNavigation { get; set; }
    }
}
