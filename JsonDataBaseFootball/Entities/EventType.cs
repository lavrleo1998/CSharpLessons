using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class EventType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EventType() { }
        public EventType(int id)
        {
            ID = id;
        }
        public EventType(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
