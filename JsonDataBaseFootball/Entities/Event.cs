using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Event
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }

        public Type Type { get; set; }
        public int EventTypeID { get; set; }
        public int TeamCompositionID { get; set; }

        public Event(int id, DateTime dateTime, int eventTipeID, int teamCompositionID, Type type)
        {
            ID = id;
            DateTime = dateTime;
            EventTypeID = eventTipeID;
            TeamCompositionID = teamCompositionID;
            Type = type;
        }
    }
}
