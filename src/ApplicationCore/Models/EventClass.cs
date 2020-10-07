using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class EventClass
    {
        public EventClass()
        {
            EventType = new HashSet<EventType>();
        }

        public decimal Neventclasskey { get; set; }
        public string Cname { get; set; }
        public string Cprefix { get; set; }
        public string Cengname { get; set; }

        public virtual ICollection<EventType> EventType { get; set; }
    }
}
