using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class FootballerTeam
    {
        public int ID { get; set; }
        public int FootbollerID { get; set; }
        public int TeamID { get; set; }
        public int PositionID { get; set; }
        public FootballerTeam(int id, int idF, int idTeam, int position)
        {
            ID = id;
            FootbollerID = idF;
            TeamID = idTeam;
            PositionID = position;
        }
    }
}
