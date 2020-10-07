using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Mappingproducts
    {
        public string Cproductcode { get; set; }
        public string Copcode { get; set; }
        public string Csql { get; set; }
        public string Cfieldlist { get; set; }
        public string Ctable { get; set; }

        public virtual Operation CopcodeNavigation { get; set; }
    }
}
