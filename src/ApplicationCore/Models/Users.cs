using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Users
    {
        public decimal Nuserkey { get; set; }
        public string Cusername { get; set; }
        public string Ccomment { get; set; }
        public decimal? Nusergroupkey { get; set; }
        public decimal? Bactive { get; set; }
        public decimal? Bfirstlogin { get; set; }
        public decimal? Itryescount { get; set; }
        public DateTime? Dpasswchangedate { get; set; }
        public decimal? Bgroup { get; set; }
        public decimal? Ilogverify { get; set; }
        public decimal? Nloguserkey { get; set; }
        public decimal? Bmandatory { get; set; }
        public string Cphoneforsms { get; set; }
        public bool? Ballowpasslogin { get; set; }
        public bool? Bidentbyad { get; set; }
    }
}
