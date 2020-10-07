using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Curracctypes
    {
        public Curracctypes()
        {
            CurraccOld = new HashSet<CurraccOld>();
        }

        public string Cacctypecode { get; set; }
        public string Cacctypename { get; set; }

        public virtual ICollection<CurraccOld> CurraccOld { get; set; }
    }
}
