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
        public static string Download()
        {
            string str = "Позиции\n";
            foreach (var position in Repository.Get<Position>())
            {
                str += "Айди: " + position.ID
                    + "; Название позиции: " + position.Name
                    + "\n";
            }
            return str;
        }
        public static void Add(int ID, string name) =>
           Repository.Add(new Position(ID, name));
        public static void Delete(int PositionID) =>
            Repository.Delete<Position>(PositionID);
        public static void Update(int ID, string name) =>
            Repository.Update<Position>(new Position(ID, name));
    }
}
