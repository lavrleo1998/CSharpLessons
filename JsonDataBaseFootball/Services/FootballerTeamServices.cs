using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    public static class FootballerTeamServices
    {
        public static string Download()
        {
            string str = "Связь футболиста и состава\n";
            foreach (var footballerTeam in Repository.Get<FootballerTeam>())
            {
                str += "Айди: " + footballerTeam.ID 
                    + "; Состав: " + Repository.Get<Team>().Where(x => x.ID == footballerTeam.TeamID).Select(x => x.Name).FirstOrDefault()
                    + "; Игрок: " + Repository.Get<Footballer>().Where(x => x.ID == footballerTeam.FootbollerID).Select(x => x.Name).FirstOrDefault()
                    + "; Позиция игрока: " + Repository.Get<Position>().Where(x => x.ID == footballerTeam.PositionID).Select(x => x.Name).FirstOrDefault()
                    + "\n";
            }
            return str;
        }
        public static void Add(int id, int idF, int idTeam, int position) =>
             Repository.Add(new FootballerTeam(id, idF, idTeam, position));
        public static void Delete(int footballerTeamID) =>
            Repository.Delete<FootballerTeam>(footballerTeamID);
        public static void Update(int id, int idF, int idTeam, int position) =>
            Repository.Update<FootballerTeam>(new FootballerTeam(id, idF, idTeam, position));

    }
}
