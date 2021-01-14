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
        public int EventTypeID { get; set; }
        public int TeamCompositionID { get; set; }

    }
}
