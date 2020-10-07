﻿using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Plfin
    {
        public DateTime Ddate { get; set; }
        public string Cproduct { get; set; }
        public decimal? Nrate { get; set; }
        public string Csource { get; set; }
        public decimal? Nytdrur { get; set; }
        public decimal? Nytdusd { get; set; }
        public decimal? Nmtdrur { get; set; }
        public decimal? Nmtdusd { get; set; }
        public decimal? Nmtdruryes { get; set; }
        public decimal? Nmtdusdyst { get; set; }
        public decimal? Ndtdrur { get; set; }
        public decimal? Ndtdusd { get; set; }
        public decimal? Ncorrect { get; set; }
        public decimal? Ncorrectrur { get; set; }
    }
}
