﻿using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class PkClientpaym
    {
        public decimal Nclientpaymkey { get; set; }
        public DateTime? Dregdate { get; set; }
        public DateTime? Dvaluedate { get; set; }
        public string Ccurrcode { get; set; }
        public string Copcode { get; set; }
        public decimal? Nsum { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nclassified { get; set; }
        public string Cdescription { get; set; }
        public string Clabel { get; set; }
        public decimal? Nacckey { get; set; }
        public DateTime? Dregtime { get; set; }
        public string Caccountcode { get; set; }
        public decimal? NuserkeyTmp { get; set; }
        public DateTime DcreatedateTmp { get; set; }
        public DateTime? DactualdateTmp { get; set; }
        public bool? BendflagTmp { get; set; }
        public decimal? NvernumberTmp { get; set; }
        public decimal? Ntt { get; set; }
    }
}
