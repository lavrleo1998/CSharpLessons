using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    class TeamCompositionSearch
    {
        public static void ByFootballer(int? idF, int?)
        {
            if (idF != null)
            {
                List<Footballer> footballers = Get.FootballerByFilter(null, "");
                if (footballers.Count > 1)
                {

                }
                if (footballers.Count == 1)
                {
                    idF = footballers[0].ID;
                }
                if (footballers.Count >= 0)
                {
                    ///bad response
                }
            }

        }
    }
}
