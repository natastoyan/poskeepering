using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Ocpdata
    {
        public DateTime Ddate { get; set; }
        public string Ccurrcode { get; set; }
        public decimal? Nsumspot { get; set; }
        public decimal? Nsumbal { get; set; }
        public decimal? Nsumvneb { get; set; }
        public decimal? Nrate { get; set; }
        public decimal? Nsumbalrur { get; set; }
        public decimal? Nsumvnebrur { get; set; }
        public decimal? Bcurrlimit { get; set; }
        public decimal? Ncurrlimit { get; set; }
        public decimal? Nsum { get; set; }
        public decimal? Nsumrur { get; set; }
        public decimal? Nrem { get; set; }
        public decimal? Nballimit { get; set; }
        public decimal? Nbalrem { get; set; }
        public decimal? Nvneblimit { get; set; }
        public decimal? Nvnebrem { get; set; }
        public decimal? Ncapital { get; set; }
        public decimal? Iocporder { get; set; }
        public decimal? Nfulllim { get; set; }
    }
}
