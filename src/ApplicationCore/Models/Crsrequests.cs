using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Crsrequests
    {
        public decimal Nrequestkey { get; set; }
        public decimal? Ndealkey { get; set; }
        public string Copcode { get; set; }
        public DateTime? Dsenddate { get; set; }
        public decimal? Irequesttype { get; set; }
        public DateTime? Dresponsedate { get; set; }
        public string Creference { get; set; }
        public decimal? Iresponseresult { get; set; }
        public decimal? Ndealkey2 { get; set; }
        public DateTime? Dadddate { get; set; }
        public DateTime? Dregdate { get; set; }
        public string Ctype { get; set; }
        public decimal? Isb { get; set; }
        public string Cresponse { get; set; }
        public string Ccomment { get; set; }
    }
}
