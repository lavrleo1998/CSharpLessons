using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Trainer : Entity
    {
        string Name { get; set; }
        public Trainer(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
