using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqproducts
    {
        public Eqproducts()
        {
            Eqprices = new HashSet<Eqprices>();
            EqpricesErms = new HashSet<EqpricesErms>();
            Equitingdeals = new HashSet<Equitingdeals>();
        }

        public decimal Nequitykey { get; set; }
        public string Cmarketcode { get; set; }
        public string Cname { get; set; }
        public string Csecurity { get; set; }
        public string Ccomment { get; set; }
        public string Csedolcode { get; set; }
        public string Cisincode { get; set; }
        public string Cproducttype { get; set; }
        public string Cstateregistrationcode { get; set; }
        public bool? Bown { get; set; }
        public string Cissuer { get; set; }

        public virtual Eqproducttype CproducttypeNavigation { get; set; }
        public virtual ICollection<Eqprices> Eqprices { get; set; }
        public virtual ICollection<EqpricesErms> EqpricesErms { get; set; }
        public virtual ICollection<Equitingdeals> Equitingdeals { get; set; }
    }
}
