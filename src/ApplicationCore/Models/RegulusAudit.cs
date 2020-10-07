using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class RegulusAudit
    {
        public decimal Nauditkey { get; set; }
        public decimal? Ndealkey { get; set; }
        public DateTime? Dchangedate { get; set; }
        public byte? Ichangetype { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nauditrecordkey { get; set; }
        public bool? Bdelete { get; set; }
    }
}
