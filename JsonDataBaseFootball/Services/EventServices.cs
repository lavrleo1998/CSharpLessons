using JsonDataBaseFootball.Repository;
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
            //Поиск футболиста
            var gottenFootballerList = Storage.Get<Footballer>();
            Footballer Footballer = new Footballer(0, "");
            foreach (var item in gottenFootballerList)
            {
                if (item.ID == footballerID)
                {
                    Footballer = item;
                    break;
                }
            }
            //Поиск связи ФутболистСостав команды 
            var gottenFootTeamCompsList = Storage.Get<FootballerTeamComposition>();
            List<FootballerTeamComposition> footTeamCompsList = new List<FootballerTeamComposition>();
            foreach (var item in gottenFootTeamCompsList)
            {
                if (item.FootbollerID == Footballer.ID)
                {
                    footTeamCompsList.Add(item);
                }
            }
            //Поиск подходящих составов
            var gottenTeamCompList = Storage.Get<TeamComposition>();
            List<TeamComposition> teamCompList = new List<TeamComposition>();
            foreach (var item in footTeamCompsList)
            {
                foreach (var item2 in gottenTeamCompList)
                {
                    if (item2.ID == item.ID)
                    {
                        teamCompList.Add(item2);
                    }
                }
            }
            //Поиск событий по составам
            var gottenEventList = Storage.Get<Event>();
            List<Event> eventList = new List<Event>();
            foreach (var item in teamCompList)
            {
                foreach (var item2 in gottenEventList)
                {
                    if (item2.ID == item.ID)
                    {
                        eventList.Add(item2);
                    }
                }
            }

            return eventList;
        }
    }
}
