using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Mappingproductcond
    {
        public string Cproductcode { get; set; }
        public string Cfieldname { get; set; }
        public string Coperator { get; set; }
        public string Cvalue { get; set; }

        public virtual Mappingproducts CproductcodeNavigation { get; set; }
    }
}
