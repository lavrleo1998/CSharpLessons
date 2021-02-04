using JsonDataBaseFootball.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonDataBaseFootball.Entities;
using System.Reflection;

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











            string className = properties[0].Name;
            int propVal = Convert.ToInt32(properties[0].GetValue(obj));

            if (className.Length > 2 & className.Contains("ID"))
            {
                int x1 = className.Length - 2;
                className = className.Remove(x1);
                var myClassType = Type.GetType(className);
                var method = typeof(Program).GetMethod("method", BindingFlags.Static | BindingFlags.Public);
                var genericMethod = method.MakeGenericMethod(myClassType);

                Repository.Get<myClassType> ().Where(x => x.ID == propVal).Select(x => x.).FirstOrDefault();


                
                

                // вернет список нужного типа - List<MyClass>
                dynamic list = genericMethod.Invoke(null, null);


            }
            return str;
        }
     
    }

}
