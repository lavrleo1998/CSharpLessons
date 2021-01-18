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
            Footballer Footballer = new Footballer(0,"");
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
                if(item.FootbollerID == Footballer.ID)
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
    }
}
