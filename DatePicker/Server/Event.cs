using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Event
    {
        String eventName;
        Dictionary<String, DateTime> datesPicked;

        public String EventName { get { return eventName; } set { } }
        public Dictionary<String, DateTime> DatesPicked { get { return datesPicked; } set { } }  

        public Event(String eventName)
        {
            this.eventName = eventName;
            DatesPicked = new Dictionary<string, DateTime>();
        }

        public void AddDatePicked(String Name, DateTime Date)
        {
            datesPicked.Add(Name, Date);
        }

    }
}
