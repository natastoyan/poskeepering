using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Closedequities
    {
        public DateTime? Ddate { get; set; }
        public decimal? Nequitykey { get; set; }
        public decimal? Npricebuy { get; set; }
        public decimal? Npricesell { get; set; }
        public decimal? Nquantity { get; set; }
        public decimal? Npl { get; set; }
        public decimal? Nbuydealkey { get; set; }
        public decimal? Nselldealkey { get; set; }
        public string Cbookcode { get; set; }
        public string Ctradecurrency { get; set; }
        public string Ccountercode { get; set; }
        public DateTime? Dchangedatetime { get; set; }
        public string Csettplace { get; set; }
        public DateTime? Deqsettdate { get; set; }

        public virtual Eqproducts NequitykeyNavigation { get; set; }
    }
}
