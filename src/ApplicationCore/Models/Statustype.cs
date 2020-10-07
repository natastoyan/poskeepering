using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class Statustype
    {
        public string Cstatustypecode { get; set; }
        public string Cstatuscode { get; set; }
        public string Ccomment { get; set; }
        public bool? Inotacceptable { get; set; }
    }
}
