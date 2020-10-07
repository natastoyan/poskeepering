using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Briefdict
    {
        public string Corgcode { get; set; }
        public string Cbrief { get; set; }

        public virtual Orgs CorgcodeNavigation { get; set; }
    }
}
