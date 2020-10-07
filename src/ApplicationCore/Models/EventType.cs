using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public partial class EventType
    {
        public EventType()
        {
            SystemEvents = new HashSet<SystemEvents>();
        }

        public string Neventtypekey { get; set; }
        public decimal? Neventclasskey { get; set; }
        public string Cdescription { get; set; }
        public string Cdescriptioneng { get; set; }
        public string Сfollowingactions { get; set; }
        public string Сfollowingactionseng { get; set; }

        public virtual EventClass NeventclasskeyNavigation { get; set; }
        public virtual ICollection<SystemEvents> SystemEvents { get; set; }
    }
}
