using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Event : Entity
    {
        public DateTime DateTime { get; set; }
        public int EventTypeID { get; set; }
        public int TeamID { get; set; }
        public Event(int id, DateTime dateTime, int eventTipeID, int teamID)
        {
            ID = id;
            DateTime = dateTime;
            EventTypeID = eventTipeID;
            TeamID = teamID;
        }
    }
}
