using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeImportfilerecords
    {
        public decimal Nfilerecordkey { get; set; }
        public decimal? Nfilekey { get; set; }
        public string Ctable { get; set; }
        public decimal? Nrecordkey { get; set; }

        public virtual IeImportfile NfilekeyNavigation { get; set; }
    }
}
