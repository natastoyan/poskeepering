using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Forms
    {
        public string Ctitle { get; set; }
        public string Cname { get; set; }
        public string Ccomment { get; set; }
        public byte[] Cdescr { get; set; }
        public string Ccreator { get; set; }
        public DateTime? Dcreationdate { get; set; }
        public decimal? Nformkey { get; set; }
    }
}
