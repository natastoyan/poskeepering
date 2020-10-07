using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Currlimits
    {
        public string Ccurrcode { get; set; }
        public DateTime Dsetdate { get; set; }
        public decimal? Ncommonlimit { get; set; }
        public decimal? Ncommonlimshort { get; set; }
        public decimal? Nballimit { get; set; }
        public decimal? Nballimitshort { get; set; }
        public decimal? Nvneblimit { get; set; }
        public decimal? Nvneblimitshort { get; set; }
        public decimal? Nadd { get; set; }

        public virtual Currency CcurrcodeNavigation { get; set; }
    }
}
