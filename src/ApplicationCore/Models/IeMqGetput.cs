using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class IeMqGetput
    {
        public DateTime Ddate { get; set; }
        public bool Naction { get; set; }
        public string Cvalue { get; set; }
        public string Cqueuename { get; set; }
    }
}
