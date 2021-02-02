using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    public static class TeamTypeServices
    {
        public static string Download()
        {
            string str = "Типы составов\n";
            foreach (var teamType in Repository.Get<TeamType>())
            {
                str += "Айди: " + teamType.ID
                    + "; Название состава: " + teamType.Name
                    + "\n";
            }
            return str;
        }
        public static void Add(int ID, string name) =>
           Repository.Add(new TeamType(ID, name));
        public static void Delete(int teamTypeID) =>
            Repository.Delete<TeamType>(teamTypeID);
        public static void Update(int ID, string name) =>
            Repository.Update<TeamType>(new TeamType(ID, name));
    }
}
