using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;

namespace JsonDataBaseFootball.Services
{
    public static class EventServices
    {
        public static List<Event> GetEventsByFootballer(int footballerID)
        {
            //Поиск связи ФутболистСостав команды 
            var footballerTeamList = Repository
                .Get<FootballerTeam>()
                .Where(x => x.FootbollerID == footballerID)
                .Select(x => x);
            //Поиск подходящих составов
            var allTeamList = new List<Team>();
            foreach (var relations in footballerTeamList)
            {
                var teamList = Repository
                    .Get<Team>()
                    .Where(x => x.ID == relations.TeamID);
                allTeamList.AddRange(teamList);
            }
            //Поиск подходщих событий    
            var allEvents = new List<Event>();
            foreach(var team in allTeamList)
            {
                var events = Repository
                    .Get<Event>()
                    .Where(x => x.TeamID == team.ID);
                allEvents.AddRange(events);
            }
            return allEvents;
        }
        
        public static List<Event> GetEventsByFootballerAndDate(int footballerID, DateTime date)
        {
            //Поиск связи ФутболистСостав команды 
            var footballerTeamList = Repository
                .Get<FootballerTeam>()
                .Where(x => x.FootbollerID == footballerID)
                .Select(x => x);
            //Поиск подходящих составов
            var allTeamList = new List<Team>();
            foreach (var relations in footballerTeamList)
            {
                var teamList = Repository
                    .Get<Team>()
                    .Where(x => x.ID == relations.TeamID);
                allTeamList.AddRange(teamList);
            }
            //Поиск подходщих событий    
            var allEvents = new List<Event>();
            foreach (var team in allTeamList)
            {
                var events = Repository
                    .Get<Event>()
                    .Where(x => x.TeamID == team.ID && x.DateTime.Date == date.Date);
                allEvents.AddRange(events);
            }
            return allEvents;
        }

    }
}
