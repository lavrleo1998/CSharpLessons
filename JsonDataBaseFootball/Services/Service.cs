using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
namespace JsonDataBaseFootball.Services
{
    public static class Helper
    {

        public static string Download(object obj)
        {
            var str = string.Empty;
            var properties = obj.GetType().GetProperties();
            foreach(var prop in properties)
            {
                str += $"Property name {prop.Name} has value = {prop.GetValue(obj)} \n";
            }
            return str;
        }
     
    }

}
