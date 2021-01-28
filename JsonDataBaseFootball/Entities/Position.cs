﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Position : Entity
    {
        public string Name { get; set; }
        public Position(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
