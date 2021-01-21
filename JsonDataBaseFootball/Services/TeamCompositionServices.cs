using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Repository;
namespace JsonDataBaseFootball.Services
{
    public static class TeamCompositionServices
    {
        public static List<string> GetTeamByFootballer(int footballerID)
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
            List<string> teamCompList = new List<string>();
            foreach (var item in footTeamCompsList)
            {
                foreach (var item2 in gottenTeamCompList)
                {
                    if (item2.ID == item.ID)
                    {
                        teamCompList.Add(item2.Name);
                    }
                }
            }
            return teamCompList;
        }
        public static List<string> GetTeamByTeamType(string teamTypeName)
        {
            var gottenTeamTypeList = Storage.Get<TeamCompositionType>();
            TeamCompositionType teamCompositionType = new TeamCompositionType(0, "");
            foreach (var item in gottenTeamTypeList)
            {
                if (item.Name == teamTypeName)
                {
                    teamCompositionType = item;
                    break;
                }
            }
            //Поиск подходящих составов
            var gottenTeamCompList = Storage.Get<TeamComposition>();
            List<string> teamCompList = new List<string>();
            foreach (var item in gottenTeamCompList)
            {
                if (item.TeamCompositionTypeID == teamCompositionType.ID)
                {
                    teamCompList.Add(item.Name);
                }
            }
            return teamCompList;
        }
        public static List<string> GetTeamByDate(DateTime date)
        {
            //Получение событий по дате
            var gottenEvent = Storage.Get<Event>();
            List<Event> eventList = new List<Event>();
            foreach (var item in gottenEvent)
            {
                if (item.DateTime.Date == date.Date)
                {
                    eventList.Add(item);
                }
            }

            //Получение составов 
            var gottenTeamCompList = Storage.Get<TeamComposition>();
            List<string> teamCompList = new List<string>();

            foreach (var item1 in eventList)
            {
                foreach (var item in gottenTeamCompList)
                {
                    if (item.ID == item1.TeamCompositionID)
                    {
                        teamCompList.Add(item.Name);
                    }
                }
            }

            List<string> retTeamCompList = new List<string>();
            retTeamCompList.Add(teamCompList[0]);
             ///доработай, цикл возвращает лишние данные.
            foreach (var item in teamCompList)
            {
                for (int i = 0; i < retTeamCompList.Count; i++)
                {
                    if (item == retTeamCompList[i])
                    {
                        break;
                    }
                    retTeamCompList.Add(item);
                }
                
            }


            return retTeamCompList.ToHashSet<string>().ToList();
        }
    }
}
///1233
///1
///5
///1233
