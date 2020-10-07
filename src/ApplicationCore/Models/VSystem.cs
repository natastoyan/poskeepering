using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class VSystem
    {
        public string Owner { get; set; }
        public decimal Nsystemkey { get; set; }
        public string Csystemcode { get; set; }
        public string Csystemname { get; set; }
        public decimal? Bmandatory { get; set; }
    }
}
