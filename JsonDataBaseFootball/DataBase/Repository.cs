using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.DataBase
{
    public static class Repository
    {
        public static void Save<T>(T objectForJSON)
        {
            //Получаем данные из файла в лист
            List<T> write = Get<T>();
            //добавляем новый объект в лист
            write.Add(objectForJSON);
            //Записываем обновленный лист в файл
            Storage.Write(JsonConvert.SerializeObject(write), typeof(T).Name + ".json");
            //string jsonString = JsonSerializer.Serialize<>(weatherForecast);
        }
        public static List<T> Get<T>()
        {
            //Получаем данные из файла
            var str = Storage.Read(typeof(T).Name + ".json");
            //десериализация до объекта
            var result = JsonConvert.DeserializeObject<List<T>>(str);
            //ВОзвращение объекта
            return result;
        }
    }
}
