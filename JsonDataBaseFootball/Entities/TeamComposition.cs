using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class TeamComposition
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TeamCompositionTypeID { get; set; }
        public TeamComposition(int id, string name, int type)
        {
            ID = id;
            Name = name;
            TeamCompositionTypeID = type;
        }
    }
}
