using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Team : Entity
    {
        public string Name { get; set; }
        public int TeamTypeID { get; set; }
        public Team(int id, string name, int type)
        {
            ID = id;
            Name = name;
            TeamTypeID = type;
        }
    }
}
