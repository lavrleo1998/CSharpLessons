using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class TeamType : Entity
    {
        public string Name { get; set; }
        public TeamType(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
