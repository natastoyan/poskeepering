using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VIeLoropayents
    {
        public DateTime? Operdate { get; set; }
        public string Label { get; set; }
        public string BoAccountcode { get; set; }
        public string BoAccountlable { get; set; }
        public decimal? Sumaccount { get; set; }
        public string BoAccountcurrency { get; set; }
        public string BeAccountlable { get; set; }
        public string Beneficiaryaccount { get; set; }
        public string Beneficiaryname { get; set; }
        public string Description { get; set; }
        public string Classified { get; set; }
    }
}
