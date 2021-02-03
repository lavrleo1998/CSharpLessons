using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
namespace JsonDataBaseFootball.Services
{
    class Service
    {
        public static string Download<T>()

        {
            var d = new Event();
            
            string str = "События\n";
            foreach (var evenT in Repository.Get<T>())
            {

                str += "Айди: " + 
            }
            return str;
        }
    }
}
