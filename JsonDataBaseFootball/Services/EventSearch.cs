using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    public static class EventSearch
    {
        public static void ByFootballerTeamCompositionSearch(int? idFTC, int? idF, int? idTC, int? idP)
        {
            if (idFTC != null)
            {
                List<Event> events = Get.EventByFilter(null, null, null, idFTC);

            }
            if (idF != null)
            {

            }
            if (idTC != null)
            {

            }
            if (idP != null)
            {

            }
        }

        
    }
}
