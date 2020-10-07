using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Collistline
    {
        public decimal Ncollistlinekey { get; set; }
        public decimal? Navailcolkey { get; set; }
        public decimal? Ncollistkey { get; set; }

        public virtual Availablecolumns NavailcolkeyNavigation { get; set; }
        public virtual Columnlists NcollistkeyNavigation { get; set; }
    }
}
