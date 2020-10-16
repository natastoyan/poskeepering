using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VtmCodes: BaseIntIdModel
    {
       // public decimal Ncodekey { get; set; }
        public string Ccode { get; set; }
        public string Cname { get; set; }
        public int? Itype { get; set; }
        public string Cisocode { get; set; }
        public string Name { get; set; }
        public short? Type { get; set; }
        public string Iso { get; set; }
    }
}
