using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VErmsExport
    {
        public string Cisincode { get; set; }
        public string Cmarketcode { get; set; }
        public string Cfake1 { get; set; }
        public string Cfake2 { get; set; }
        public string Cfake3 { get; set; }
        public string Cfake4 { get; set; }
        public string Cbookcode { get; set; }
        public string Ctradecurrcode { get; set; }
        public decimal? Position { get; set; }
        public decimal? Ermsprice { get; set; }
    }
}
