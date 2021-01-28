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
        public static void Add(int id, int idF, int idTeam, int position) =>
             Repository.Add(new FootballerTeam(id, idF, idTeam, position));
        public static void Delete(int footballerTeamID) =>
            Repository.Delete<FootballerTeam>(footballerTeamID);
        public static void Update(int id, int idF, int idTeam, int position) =>
            Repository.Update<FootballerTeam>(new FootballerTeam(id, idF, idTeam, position));

    }
}
