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
            //Поиск футболиста c проверкой есть ли он, проверка пока не работает
            /*
            var gottenFootballerList = Storage.Get<Footballer>();
            Footballer Footballer = new Footballer(0, "");
            foreach (var item in gottenFootballerList)
            {
                if (item.ID == footballerID)
                {
                    Footballer = item;
                    break;
                }
            }*/
            //Поиск связи ФутболистСостав команды 
            var gottenFootTeamCompsList = Storage.Get<FootballerTeamComposition>();
            var footTeamCompsList = new List<FootballerTeamComposition>();
            foreach (var item in gottenFootTeamCompsList)
            {
                if (item.FootbollerID == footballerID)
                {
                    footTeamCompsList.Add(item);
                }
            }
            //Поиск подходящих составов
            var gottenTeamCompList = Storage.Get<TeamComposition>();
            var teamCompList = new List<TeamComposition>();
            foreach (var item in footTeamCompsList)
            {
                foreach (var item2 in gottenTeamCompList)
                {
                    if (item2.ID == item.TeamCompositionID)
                    {
                        teamCompList.Add(item2);
                    }
                }
            }
            //Поиск событий по составам
            var gottenEventList = Storage.Get<Event>();
            var eventList = new List<Event>();
            foreach (var item in teamCompList)
            {
                foreach (var item2 in gottenEventList)
                {
                    if (item2.TeamCompositionID == item.ID)
                    {
                        eventList.Add(item2);
                    }
                }
            }

            return eventList;
        }

        public static List<Event> GetEventsByFootballerAndDate(int footballerID, DateTime date)
        {
            var gottenFootTeamCompsList = Storage.Get<FootballerTeamComposition>();
            var footTeamCompsList = new List<FootballerTeamComposition>();
            foreach (var item in gottenFootTeamCompsList)
            {
                if (item.FootbollerID == footballerID)
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
                    if (item2.ID == item.TeamCompositionID)
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
                    if (item2.TeamCompositionID == item.ID)
                    {
                        eventList.Add(item2);
                    }
                }
            }
            //поиск события по дате

            List<Event> eventListByDate = new List<Event>();
            foreach (var item in eventList)
            {
                if (item.DateTime.Date == date.Date)
                {
                    eventListByDate.Add(item);
                }
            }

            eventList.Where(x => x.EventTypeID == 1);

            return eventListByDate;
        }

    }
}
