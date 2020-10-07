using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VPkBooks
    {
        public string Cbookcode { get; set; }
        public string Cbookname { get; set; }
        public string Csummitbookcode { get; set; }
        public string Cdealercode { get; set; }
        public string Csummitdeskcode { get; set; }
        public string Cathenabookcode { get; set; }
        public string Catlasbookcode { get; set; }
        public bool? Batlasexport { get; set; }
        public string Ccompany { get; set; }
        public string Ccounterparty { get; set; }
        public bool? Bactive { get; set; }
        public bool? Bcrsexport { get; set; }
        public bool? Bsummitexport { get; set; }
        public string Cdiasoftbookcode { get; set; }
        public bool? Bathenaintexport { get; set; }
    }
}
