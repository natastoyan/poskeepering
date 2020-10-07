using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class TabLog
    {
        public DateTime? Dlastdate { get; set; }
        public string Cerrpositionfield { get; set; }
        public string Cerrorfield { get; set; }
        public string Csheme { get; set; }
        public string Ctablename { get; set; }
    }
}
