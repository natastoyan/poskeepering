using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Productbookmapping
    {
        public string Cproductcode { get; set; }
        public string Cdealercode { get; set; }
        public string Cbookcode { get; set; }

        public virtual Books CbookcodeNavigation { get; set; }
        public virtual Mappingproducts CproductcodeNavigation { get; set; }
    }
}
