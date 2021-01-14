using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Footballer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Footballer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
