using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class FootballerTeamComposition
    {
        public int ID { get; set; }
        public int FootbollerID { get; set; }
        public int TeamCompositionID { get; set; }
        public int PositionID { get; set; }
        public FootballerTeamComposition(int id, int idF, int idTeam, int position)
        {
            ID = id;
            FootbollerID = idF;
            TeamCompositionID = idTeam;
            PositionID = position;
        }
    }
}
