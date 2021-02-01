using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
namespace JsonDataBaseFootball.Services
{
    public static class FootballerServices
    {
        public static string Download()
        {
            string str = "Футболисты\n";
            foreach (var footballer in Repository.Get<Footballer>())
            {
                str += "Айди: " + footballer.ID 
                    + "; Имя футболиста: " + footballer.Name 
                    + "\n";
            }
            return str;
        }
        public static void Add(int ID, string name) => 
            Repository.Add(new Footballer(ID, name));
        public static void Delete(int footballerID)=> 
            Repository.Delete<Footballer>(footballerID);
        public static void Update(int ID, string newName)=> 
            Repository.Update<Footballer>(new Footballer(ID, newName));
        
    }
}
