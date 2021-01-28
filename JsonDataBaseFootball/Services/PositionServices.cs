using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    class PositionServices
    {
        public static void Add(int ID, string name) =>
           Repository.Add(new Position(ID, name));
        public static void Delete(int PositionID) =>
            Repository.Delete<Position>(PositionID);
        public static void Update(int ID, string name) =>
            Repository.Update<Position>(new Position(ID, name));
    }
}
