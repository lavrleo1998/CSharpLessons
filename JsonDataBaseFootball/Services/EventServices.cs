using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;

namespace JsonDataBaseFootball.Services
{
    public class EventServices
    {

        public static string Download()

        {
            string str = "События\n";
            foreach (var evenT in Repository.Get<Event>())
            {

                str += "Айди: " + evenT.ID + "; Дата: " + evenT.DateTime.ToString()
                    + "; Тип события: " + Repository.Get<EventType>().Where(x => x.ID == evenT.EventTypeID).Select(x => x.Name).FirstOrDefault()
                    + "; Играющий состав: " + Repository.Get<Team>().Where(x => x.ID == evenT.TeamID).Select(x => x.Name).FirstOrDefault() + "\n";

            }
            return str;
        }
        public static void Add(int id, DateTime dateTime, int eventTipeID, int teamID) 
        { 
            Repository.Add(new Event(id, dateTime, eventTipeID, teamID)); 
        }
        public static void Delete(int eventID) 
        {
            Repository.Delete<Event>(eventID);
        }     
        public static void Update(int id, DateTime dateTime, int eventTipeID, int teamID)
        {
            Repository.Update<Event>(new Event(id, dateTime, eventTipeID, teamID));
        }
        public static List<Event> GetByFootballer(int footballerID)
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
                    .Where(x => x.TeamID == team.ID);
                allEvents.AddRange(events);
            }
            return allEvents;
        }

        public static List<Event> GetByFootballerAndDate(int footballerID, DateTime date)
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
