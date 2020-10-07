using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Eqproducttype
    {
        public Eqproducttype()
        {
            Eqproducts = new HashSet<Eqproducts>();
        }

        public string Cproducttypecode { get; set; }
        public string Ccomment { get; set; }

        public virtual ICollection<Eqproducts> Eqproducts { get; set; }
    }
}
