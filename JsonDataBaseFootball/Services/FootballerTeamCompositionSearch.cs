using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    class FootballerTeamCompositionSearch
    {
        public static int ByFootballer(int? idF)
        {
            int idFTC;
            if (idF != null)
            {
                List<FootballerTeamComposition> footballerTeamCompositions = Get.FootballerTeamCompositionByFilter(null,idF,null,null);
                if (footballerTeamCompositions.Count > 1)
                {
                    
                }
                if (footballerTeamCompositions.Count == 1)
                {
                   return idFTC = footballerTeamCompositions[0].ID;
                }
                if (footballerTeamCompositions.Count >= 0)
                {
                    ///bad response
                }
            }
            return idFTC = 0;
        }
    }
}
