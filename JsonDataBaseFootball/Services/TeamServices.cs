using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.DataBase;
namespace JsonDataBaseFootball.Services
{
    public static class TeamServices
    {
        public static void Add(int ID, string name, int teamTypeId) =>
            Repository.Add(new Team(ID, name, teamTypeId));
        public static void Delete(int teamID) =>
            Repository.Delete<Team>(teamID);
        public static void Update(int ID, string name, int teamTypeId) =>
            Repository.Update<Team>(new Team(ID, name, teamTypeId));
        public static List<string> GetByFootballer(int footballerID)
        {
            //Поиск связи ФутболистСостав команды 
            var footballerTeamList = Repository
                .Get<FootballerTeam>()
                .Where(x => x.FootbollerID == footballerID)
                .Select(x => x);
            //Поиск подходящих составов
            var allTeamList = new List<string>();
            foreach (var relations in footballerTeamList)
            {
                var teamList = Repository
                    .Get<Team>()
                    .Where(x => x.ID == relations.TeamID)
                    .Select(x => x.Name);
                allTeamList.AddRange(teamList);
            }
            return allTeamList;
        }
        public static List<string> GetByTeamType(string teamTypeName)
        {
            var teamTypeList = Repository
                .Get<TeamType>()
                .Where(x => x.Name == teamTypeName)
                .Select(x => x);

            var allTeamList = new List<string>();
            foreach (var teamType in teamTypeList)
            {
                var teamList = Repository
                .Get<Team>()
                .Where(x => x.TeamTypeID == teamType.ID)
                .Select(x => x.Name);
                allTeamList.AddRange(teamList);
            }
            return allTeamList;

        }
        public static List<string> GetTByDate(DateTime date)
        {
            var eventList = Repository
                .Get<Event>()
                .Where(x => x.DateTime.Date == date.Date)
                .Select(x => x.TeamID);

            var allEvent = new List<string>();
            foreach (var evenT in eventList)
            {
                var teamList = Repository
                .Get<Team>()
                .Where(x => x.ID == evenT)
                .Select(x => x.Name);
                allEvent.AddRange(teamList);
            }
            return allEvent;
        }


    }
}
